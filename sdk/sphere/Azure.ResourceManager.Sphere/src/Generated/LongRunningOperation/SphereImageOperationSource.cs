// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sphere
{
    internal class SphereImageOperationSource : IOperationSource<SphereImageResource>
    {
        private readonly ArmClient _client;

        internal SphereImageOperationSource(ArmClient client)
        {
            _client = client;
        }

        SphereImageResource IOperationSource<SphereImageResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SphereImageData.DeserializeSphereImageData(document.RootElement);
            return new SphereImageResource(_client, data);
        }

        async ValueTask<SphereImageResource> IOperationSource<SphereImageResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SphereImageData.DeserializeSphereImageData(document.RootElement);
            return new SphereImageResource(_client, data);
        }
    }
}
