// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudTrunkedNetworkResource"/> and their operations.
    /// Each <see cref="NetworkCloudTrunkedNetworkResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkCloudTrunkedNetworkCollection"/> instance call the GetNetworkCloudTrunkedNetworks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkCloudTrunkedNetworkCollection : ArmCollection, IEnumerable<NetworkCloudTrunkedNetworkResource>, IAsyncEnumerable<NetworkCloudTrunkedNetworkResource>
    {
        private readonly ClientDiagnostics _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics;
        private readonly TrunkedNetworksRestOperations _networkCloudTrunkedNetworkTrunkedNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudTrunkedNetworkCollection"/> class for mocking. </summary>
        protected NetworkCloudTrunkedNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudTrunkedNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudTrunkedNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudTrunkedNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudTrunkedNetworkResource.ResourceType, out string networkCloudTrunkedNetworkTrunkedNetworksApiVersion);
            _networkCloudTrunkedNetworkTrunkedNetworksRestClient = new TrunkedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudTrunkedNetworkTrunkedNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new trunked network or update the properties of the existing trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudTrunkedNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string trunkedNetworkName, NetworkCloudTrunkedNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudTrunkedNetworkResource>(new NetworkCloudTrunkedNetworkOperationSource(Client), _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new trunked network or update the properties of the existing trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudTrunkedNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string trunkedNetworkName, NetworkCloudTrunkedNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudTrunkedNetworkResource>(new NetworkCloudTrunkedNetworkOperationSource(Client), _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> GetAsync(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual Response<NetworkCloudTrunkedNetworkResource> Get(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of trunked networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudTrunkedNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudTrunkedNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudTrunkedNetworkResource(Client, NetworkCloudTrunkedNetworkData.DeserializeNetworkCloudTrunkedNetworkData(e)), _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, "NetworkCloudTrunkedNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of trunked networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudTrunkedNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudTrunkedNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudTrunkedNetworkResource(Client, NetworkCloudTrunkedNetworkData.DeserializeNetworkCloudTrunkedNetworkData(e)), _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, "NetworkCloudTrunkedNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudTrunkedNetworkResource>> GetIfExistsAsync(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudTrunkedNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudTrunkedNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trunkedNetworkName"> The name of the trunked network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trunkedNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trunkedNetworkName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudTrunkedNetworkResource> GetIfExists(string trunkedNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trunkedNetworkName, nameof(trunkedNetworkName));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, trunkedNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudTrunkedNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudTrunkedNetworkResource> IEnumerable<NetworkCloudTrunkedNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudTrunkedNetworkResource> IAsyncEnumerable<NetworkCloudTrunkedNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
