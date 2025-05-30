// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class HubVirtualNetworkConnectionOperationSource : IOperationSource<HubVirtualNetworkConnectionResource>
    {
        private readonly ArmClient _client;

        internal HubVirtualNetworkConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HubVirtualNetworkConnectionResource IOperationSource<HubVirtualNetworkConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HubVirtualNetworkConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new HubVirtualNetworkConnectionResource(_client, data);
        }

        async ValueTask<HubVirtualNetworkConnectionResource> IOperationSource<HubVirtualNetworkConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HubVirtualNetworkConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new HubVirtualNetworkConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
