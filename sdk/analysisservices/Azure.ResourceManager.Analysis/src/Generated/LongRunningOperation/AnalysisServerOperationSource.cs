// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Analysis
{
    internal class AnalysisServerOperationSource : IOperationSource<AnalysisServerResource>
    {
        private readonly ArmClient _client;

        internal AnalysisServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        AnalysisServerResource IOperationSource<AnalysisServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AnalysisServerData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAnalysisContext.Default);
            return new AnalysisServerResource(_client, data);
        }

        async ValueTask<AnalysisServerResource> IOperationSource<AnalysisServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AnalysisServerData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAnalysisContext.Default);
            return await Task.FromResult(new AnalysisServerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
