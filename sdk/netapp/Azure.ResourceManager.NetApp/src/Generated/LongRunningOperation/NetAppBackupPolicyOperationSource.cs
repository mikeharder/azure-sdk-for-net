// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetApp
{
    internal class NetAppBackupPolicyOperationSource : IOperationSource<NetAppBackupPolicyResource>
    {
        private readonly ArmClient _client;

        internal NetAppBackupPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetAppBackupPolicyResource IOperationSource<NetAppBackupPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetAppBackupPolicyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetAppContext.Default);
            return new NetAppBackupPolicyResource(_client, data);
        }

        async ValueTask<NetAppBackupPolicyResource> IOperationSource<NetAppBackupPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetAppBackupPolicyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetAppContext.Default);
            return await Task.FromResult(new NetAppBackupPolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
