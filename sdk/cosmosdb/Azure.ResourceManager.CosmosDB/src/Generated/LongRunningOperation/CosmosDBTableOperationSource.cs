// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBTableOperationSource : IOperationSource<CosmosDBTableResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBTableOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBTableResource IOperationSource<CosmosDBTableResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBTableData.DeserializeCosmosDBTableData(document.RootElement);
            return new CosmosDBTableResource(_client, data);
        }

        async ValueTask<CosmosDBTableResource> IOperationSource<CosmosDBTableResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBTableData.DeserializeCosmosDBTableData(document.RootElement);
            return new CosmosDBTableResource(_client, data);
        }
    }
}
