// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Quantum
{
    internal class QuantumWorkspaceOperationSource : IOperationSource<QuantumWorkspaceResource>
    {
        private readonly ArmClient _client;

        internal QuantumWorkspaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        QuantumWorkspaceResource IOperationSource<QuantumWorkspaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = QuantumWorkspaceData.DeserializeQuantumWorkspaceData(document.RootElement);
            return new QuantumWorkspaceResource(_client, data);
        }

        async ValueTask<QuantumWorkspaceResource> IOperationSource<QuantumWorkspaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = QuantumWorkspaceData.DeserializeQuantumWorkspaceData(document.RootElement);
            return new QuantumWorkspaceResource(_client, data);
        }
    }
}
