// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsResolverPolicyVirtualNetworkLinkOperationSource : IOperationSource<DnsResolverPolicyVirtualNetworkLinkResource>
    {
        private readonly ArmClient _client;

        internal DnsResolverPolicyVirtualNetworkLinkOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsResolverPolicyVirtualNetworkLinkResource IOperationSource<DnsResolverPolicyVirtualNetworkLinkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DnsResolverPolicyVirtualNetworkLinkData.DeserializeDnsResolverPolicyVirtualNetworkLinkData(document.RootElement);
            return new DnsResolverPolicyVirtualNetworkLinkResource(_client, data);
        }

        async ValueTask<DnsResolverPolicyVirtualNetworkLinkResource> IOperationSource<DnsResolverPolicyVirtualNetworkLinkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DnsResolverPolicyVirtualNetworkLinkData.DeserializeDnsResolverPolicyVirtualNetworkLinkData(document.RootElement);
            return new DnsResolverPolicyVirtualNetworkLinkResource(_client, data);
        }
    }
}
