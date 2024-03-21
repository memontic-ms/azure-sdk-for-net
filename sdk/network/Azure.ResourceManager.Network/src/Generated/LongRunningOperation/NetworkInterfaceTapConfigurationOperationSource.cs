// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class NetworkInterfaceTapConfigurationOperationSource : IOperationSource<NetworkInterfaceTapConfigurationResource>
    {
        private readonly ArmClient _client;

        internal NetworkInterfaceTapConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkInterfaceTapConfigurationResource IOperationSource<NetworkInterfaceTapConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(document.RootElement);
            return new NetworkInterfaceTapConfigurationResource(_client, data);
        }

        async ValueTask<NetworkInterfaceTapConfigurationResource> IOperationSource<NetworkInterfaceTapConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(document.RootElement);
            return new NetworkInterfaceTapConfigurationResource(_client, data);
        }
    }
}
