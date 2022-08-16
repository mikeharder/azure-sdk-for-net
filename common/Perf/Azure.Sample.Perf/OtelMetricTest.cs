// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Test.Perf;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Sample.Perf
{
    // Used for measuring the overhead of the perf framework with the fastest possible test
    public class OtelMetricTest : PerfTest<PerfOptions>
    {
        private static readonly Meter MyMeter = new("MyCompany.MyProduct.MyLibrary", "1.0");
        private static readonly Counter<long> MyFruitCounter = MyMeter.CreateCounter<long>("MyFruitCounter");

        private Timer _timer;
        private List<Metric> _exportedMetrics = new List<Metric>();
        private MeterProvider _meterProvider;

        public OtelMetricTest(PerfOptions options) : base(options)
        {
            _meterProvider = Sdk.CreateMeterProviderBuilder()
                .AddMeter("MyCompany.MyProduct.MyLibrary")
                .AddInMemoryExporter(_exportedMetrics)
                .Build();

            _timer = new Timer((state) => FlushAndLog(), state: null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        public void FlushAndLog()
        {
            _meterProvider.ForceFlush();

            var metric = _exportedMetrics.LastOrDefault();

            if (metric != null)
            {
                Console.WriteLine($"{metric.Name}");
                var metricPoints = metric.GetMetricPoints();
                foreach (var metricPoint in metricPoints)
                {
                    Console.WriteLine(metricPoint.GetSumLong());
                }
            }
        }

        public override void Dispose(bool disposing)
        {
            _timer.Dispose();
            _meterProvider.Dispose();
            base.Dispose(disposing);
        }

        public override void Run(CancellationToken cancellationToken)
        {
            MyFruitCounter.Add(1);
        }

        public override Task RunAsync(CancellationToken cancellationToken)
        {
            MyFruitCounter.Add(1);
            return Task.CompletedTask;
        }
    }
}
