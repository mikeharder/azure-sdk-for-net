// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;
using Azure.Storage.Blobs;
using Azure.Test.Perf;

namespace Azure.Template.Perf
{
    public class EventProcessorClientTest : PerfTest<EventProcessorClientTest.EventProcessorClientTestOptions>
    {
        private static readonly string _storageConnectionString = Environment.GetEnvironmentVariable("STORAGE_CONNECTION_STRING");
        private static readonly string _eventHubsConnectionString = Environment.GetEnvironmentVariable("EVENT_HUBS_CONNECTION_STRING");
        private static readonly string _eventHubName = Environment.GetEnvironmentVariable("EVENT_HUB_NAME");

        private readonly BlobContainerClient _storageClient;
        private readonly EventProcessorClient _eventProcessorClient;
        private readonly CancellationTokenSource _eventProcessorClientCts;

        private readonly SemaphoreSlim _eventsProcessed = new SemaphoreSlim(0);
        private readonly SemaphoreSlim _nextEventsToProcess = new SemaphoreSlim(0);

        public EventProcessorClientTest(EventProcessorClientTestOptions options) : base(options)
        {
            var containerName = Guid.NewGuid().ToString();
            _storageClient = new BlobContainerClient(
                _storageConnectionString,
                containerName);

            _eventProcessorClient = new EventProcessorClient(
                _storageClient,
                EventHubConsumerClient.DefaultConsumerGroupName,
                _eventHubsConnectionString,
                _eventHubName,
                new EventProcessorClientOptions() { LoadBalancingStrategy = LoadBalancingStrategy.Greedy }
            );

            _eventProcessorClientCts = new CancellationTokenSource();
        }

        public override async Task SetupAsync()
        {
            await base.SetupAsync();

            await _storageClient.CreateAsync();

            // attach event handlers
            _eventProcessorClient.ProcessEventAsync += ProcessEventHandler;
            _eventProcessorClient.ProcessErrorAsync += ProcessErrorHandler;

            // start processor
            await _eventProcessorClient.StartProcessingAsync(_eventProcessorClientCts.Token);
        }

        public override async Task CleanupAsync()
        {
            _eventProcessorClientCts.Cancel();
            await _eventProcessorClient.StopProcessingAsync();

            _eventProcessorClient.ProcessEventAsync -= ProcessEventHandler;
            _eventProcessorClient.ProcessErrorAsync -= ProcessErrorHandler;

            await _storageClient.DeleteAsync();

            await base.CleanupAsync();
        }

        public override void Run(CancellationToken cancellationToken)
        {
            throw new InvalidOperationException();
        }

        private async Task ProcessEventHandler(ProcessEventArgs args)
        {
            _eventsProcessed.Release();
            await _nextEventsToProcess.WaitAsync(args.CancellationToken);
        }

        private Task ProcessErrorHandler(ProcessErrorEventArgs args)
        {
            throw args.Exception;
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await _eventsProcessed.WaitAsync(cancellationToken);
            _nextEventsToProcess.Release();
        }

        public class EventProcessorClientTestOptions : PerfOptions
        {
        }
    }
}
