// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Test.Perf;
using CommandLine;

namespace Azure.Template.Perf
{
    public class EventProcessorClientTest : PerfTest<EventProcessorClientTest.EventProcessorClientTestOptions>
    {
        public EventProcessorClientTest(EventProcessorClientTestOptions options) : base(options)
        {
        }

        public override void Run(CancellationToken cancellationToken)
        {
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }

        public class EventProcessorClientTestOptions : PerfOptions
        {
        }
    }
}
