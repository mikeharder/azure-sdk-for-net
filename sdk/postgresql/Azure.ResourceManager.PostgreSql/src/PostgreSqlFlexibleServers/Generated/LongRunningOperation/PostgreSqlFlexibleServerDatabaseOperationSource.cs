// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal class PostgreSqlFlexibleServerDatabaseOperationSource : IOperationSource<PostgreSqlFlexibleServerDatabaseResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlFlexibleServerDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlFlexibleServerDatabaseResource IOperationSource<PostgreSqlFlexibleServerDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlFlexibleServerDatabaseData>(response.Content);
            return new PostgreSqlFlexibleServerDatabaseResource(_client, data);
        }

        async ValueTask<PostgreSqlFlexibleServerDatabaseResource> IOperationSource<PostgreSqlFlexibleServerDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlFlexibleServerDatabaseData>(response.Content);
            return await Task.FromResult(new PostgreSqlFlexibleServerDatabaseResource(_client, data)).ConfigureAwait(false);
        }
    }
}
