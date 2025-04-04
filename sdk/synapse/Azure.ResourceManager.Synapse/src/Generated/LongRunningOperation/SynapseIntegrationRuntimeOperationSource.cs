// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseIntegrationRuntimeOperationSource : IOperationSource<SynapseIntegrationRuntimeResource>
    {
        private readonly ArmClient _client;

        internal SynapseIntegrationRuntimeOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseIntegrationRuntimeResource IOperationSource<SynapseIntegrationRuntimeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseIntegrationRuntimeData>(response.Content);
            return new SynapseIntegrationRuntimeResource(_client, data);
        }

        async ValueTask<SynapseIntegrationRuntimeResource> IOperationSource<SynapseIntegrationRuntimeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseIntegrationRuntimeData>(response.Content);
            return await Task.FromResult(new SynapseIntegrationRuntimeResource(_client, data)).ConfigureAwait(false);
        }
    }
}
