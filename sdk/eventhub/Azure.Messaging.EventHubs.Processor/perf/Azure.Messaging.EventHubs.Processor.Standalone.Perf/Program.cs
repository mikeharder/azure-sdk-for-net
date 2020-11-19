// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;
using Azure.Messaging.EventHubs.Producer;
using Azure.Storage.Blobs;

namespace Azure.Template.Perf
{
    public class Program
    {
        private static readonly string _storageConnectionString = Environment.GetEnvironmentVariable("STORAGE_CONNECTION_STRING");
        private static readonly string _blobContainerName = Environment.GetEnvironmentVariable("BLOB_CONTAINER_NAME");

        private static readonly string _eventHubsConnectionString = Environment.GetEnvironmentVariable("EVENT_HUBS_CONNECTION_STRING");
        private static readonly string _eventHubName = Environment.GetEnvironmentVariable("EVENT_HUB_NAME");

        public static Task Main(string[] args)
        {
            var command = args.FirstOrDefault()?.ToLowerInvariant();
            Int32.TryParse(args.Skip(1).FirstOrDefault(), out var count);

            switch (command)
            {
                case "produce":
                    return ProduceAsync(count);
                case "process":
                    return ProcessAsync(count);
                default:
                    return HelpAsync(command);
            }
        }

        private static async Task ProduceAsync(int count)
        {
            var producer = new EventHubProducerClient(_eventHubsConnectionString, _eventHubName);

            try
            {
                var eventsSent = 0;
                while (eventsSent < count)
                {
                    using EventDataBatch eventBatch = await producer.CreateBatchAsync();

                    for (; eventsSent < count; ++eventsSent)
                    {
                        Console.WriteLine(eventsSent);

                        var eventBody = new BinaryData($"Event Number: { eventsSent }");
                        var eventData = new EventData(eventBody);

                        if (!eventBatch.TryAdd(eventData))
                        {
                            // At this point, the batch is full but our last event was not
                            // accepted.  For our purposes, the event is unimportant so we
                            // will intentionally ignore it.  In a real-world scenario, a
                            // decision would have to be made as to whether the event should
                            // be dropped or published on its own.

                            --eventsSent;

                            break;
                        }
                    }

                    // When the producer publishes the event, it will receive an
                    // acknowledgment from the Event Hubs service; so long as there is no
                    // exception thrown by this call, the service assumes responsibility for
                    // delivery.  Your event data will be published to one of the Event Hub
                    // partitions, though there may be a (very) slight delay until it is
                    // available to be consumed.

                    await producer.SendAsync(eventBatch);
                }
            }
            catch
            {
                // Transient failures will be automatically retried as part of the
                // operation. If this block is invoked, then the exception was either
                // fatal or all retries were exhausted without a successful publish.
            }
            finally
            {
                await producer.CloseAsync();
            }
        }


        private static async Task ProcessAsync(int count)
        {
            var containerName = Guid.NewGuid().ToString();

            var storageClient = new BlobContainerClient(
                _storageConnectionString,
                containerName);

            await storageClient.CreateAsync();

            var processor = new EventProcessorClient(
                storageClient,
                EventHubConsumerClient.DefaultConsumerGroupName,
                _eventHubsConnectionString,
                _eventHubName);

            int eventsProcessed = 0;
            int errorsProcessed = 0;

            using var cancellationSource = new CancellationTokenSource();

            Task processEventHandler(ProcessEventArgs args)
            {
                if (Interlocked.Increment(ref eventsProcessed) >= count)
                {
                    cancellationSource.Cancel();
                }
                return Task.CompletedTask;
            }

            Task processErrorHandler(ProcessErrorEventArgs args)
            {
                Interlocked.Increment(ref errorsProcessed);
                return Task.CompletedTask;
            }

            try
            {
                processor.ProcessEventAsync += processEventHandler;
                processor.ProcessErrorAsync += processErrorHandler;

                var sw = Stopwatch.StartNew();
                try
                {
                    await processor.StartProcessingAsync(cancellationSource.Token);
                    await Task.Delay(Timeout.Infinite, cancellationSource.Token);
                }
                catch (TaskCanceledException)
                {
                    // This is expected if the cancellation token is
                    // signaled.
                }
                finally
                {
                    sw.Stop();
                    var eventsPerSecond = eventsProcessed / sw.Elapsed.TotalSeconds;
                    Console.WriteLine($"Processed {eventsProcessed} events in {sw.Elapsed.TotalSeconds} seconds ({eventsPerSecond:N2} events/sec)");

                    // This may take up to the length of time defined
                    // as part of the configured TryTimeout of the processor;
                    // by default, this is 60 seconds.
                    await processor.StopProcessingAsync();
                }
            }
            catch
            {
                // The processor will automatically attempt to recover from any
                // failures, either transient or fatal, and continue processing.
                // Errors in the processor's operation will be surfaced through
                // its error handler.
                //
                // If this block is invoked, then something external to the
                // processor was the source of the exception.
            }
            finally
            {
                // It is encouraged that you unregister your handlers when you have
                // finished using the Event Processor to ensure proper cleanup.  This
                // is especially important when using lambda expressions or handlers
                // in any form that may contain closure scopes or hold other references.

                processor.ProcessEventAsync -= processEventHandler;
                processor.ProcessErrorAsync -= processErrorHandler;

                await storageClient.DeleteAsync();
            }
        }

        private static Task HelpAsync(string command)
        {
            Console.WriteLine($"Invalid command '{command}'");
            return Task.CompletedTask;
        }
    }
}
