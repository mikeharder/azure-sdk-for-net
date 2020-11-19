// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Template.Perf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("EVENT_HUBS_CONNECTION_STRING");
            var eventHubName = Environment.GetEnvironmentVariable("EVENT_HUB_NAME");
        }
    }
}
