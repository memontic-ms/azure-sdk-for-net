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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkDeviceResource"/> and their operations.
    /// Each <see cref="NetworkDeviceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkDeviceCollection"/> instance call the GetNetworkDevices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkDeviceCollection : ArmCollection, IEnumerable<NetworkDeviceResource>, IAsyncEnumerable<NetworkDeviceResource>
    {
        private readonly ClientDiagnostics _networkDeviceClientDiagnostics;
        private readonly NetworkDevicesRestOperations _networkDeviceRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceCollection"/> class for mocking. </summary>
        protected NetworkDeviceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkDeviceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkDeviceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkDeviceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkDeviceResource.ResourceType, out string networkDeviceApiVersion);
            _networkDeviceRestClient = new NetworkDevicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkDeviceApiVersion);
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
        /// Create a Network Device resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkDeviceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkDeviceName, NetworkDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkDeviceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkDeviceResource>(new NetworkDeviceOperationSource(Client), _networkDeviceClientDiagnostics, Pipeline, _networkDeviceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Network Device resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkDeviceResource> CreateOrUpdate(WaitUntil waitUntil, string networkDeviceName, NetworkDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkDeviceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkDeviceResource>(new NetworkDeviceOperationSource(Client), _networkDeviceClientDiagnostics, Pipeline, _networkDeviceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Network Device resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual async Task<Response<NetworkDeviceResource>> GetAsync(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkDeviceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Network Device resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual Response<NetworkDeviceResource> Get(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = _networkDeviceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the Network Device resources in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkDeviceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkDeviceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkDeviceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkDeviceResource(Client, NetworkDeviceData.DeserializeNetworkDeviceData(e)), _networkDeviceClientDiagnostics, Pipeline, "NetworkDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the Network Device resources in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkDeviceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkDeviceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkDeviceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkDeviceResource(Client, NetworkDeviceData.DeserializeNetworkDeviceData(e)), _networkDeviceClientDiagnostics, Pipeline, "NetworkDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkDeviceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkDeviceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkDeviceResource>> GetIfExistsAsync(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkDeviceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkDeviceResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDevices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkDeviceName"> Name of the Network Device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkDeviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkDeviceName"/> is null. </exception>
        public virtual NullableResponse<NetworkDeviceResource> GetIfExists(string networkDeviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkDeviceName, nameof(networkDeviceName));

            using var scope = _networkDeviceClientDiagnostics.CreateScope("NetworkDeviceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkDeviceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkDeviceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkDeviceResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkDeviceResource> IEnumerable<NetworkDeviceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkDeviceResource> IAsyncEnumerable<NetworkDeviceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
