// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Test.Perf;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Sample.Perf
{
    public class SemaphoreTest : PerfTest<PerfOptions>
    {
        private readonly SemaphoreSlim _eventsProcessed = new SemaphoreSlim(0);
        private readonly SemaphoreSlim _nextEventsToProcess = new SemaphoreSlim(0);

        private readonly CancellationTokenSource _backgroundProcessorCts;
        private Task _backgroundProcessor;

        public SemaphoreTest(PerfOptions options) : base(options)
        {
            _backgroundProcessorCts = new CancellationTokenSource();
        }

        public override async Task SetupAsync()
        {
            await base.SetupAsync();

            _backgroundProcessor = BackgroundProcessor(_backgroundProcessorCts.Token);
        }

        public override async Task CleanupAsync()
        {
            _backgroundProcessorCts.Cancel();
            try
            {
                await _backgroundProcessor;
            }
            catch (OperationCanceledException)
            {
            }

            await base.CleanupAsync();
        }

        private async Task BackgroundProcessor(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                _eventsProcessed.Release();
                await _nextEventsToProcess.WaitAsync(cancellationToken);
            }
        }

        public override void Run(CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await _eventsProcessed.WaitAsync(cancellationToken);
            _nextEventsToProcess.Release();
        }
    }
}
