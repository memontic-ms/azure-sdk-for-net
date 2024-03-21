// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService
{
    internal class HybridContainerServiceAgentPoolOperationSource : IOperationSource<HybridContainerServiceAgentPoolResource>
    {
        private readonly ArmClient _client;

        internal HybridContainerServiceAgentPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        HybridContainerServiceAgentPoolResource IOperationSource<HybridContainerServiceAgentPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(document.RootElement);
            return new HybridContainerServiceAgentPoolResource(_client, data);
        }

        async ValueTask<HybridContainerServiceAgentPoolResource> IOperationSource<HybridContainerServiceAgentPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(document.RootElement);
            return new HybridContainerServiceAgentPoolResource(_client, data);
        }
    }
}
