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

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerGroupResource"/> and their operations.
    /// Each <see cref="ContainerGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ContainerGroupCollection"/> instance call the GetContainerGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ContainerGroupCollection : ArmCollection, IEnumerable<ContainerGroupResource>, IAsyncEnumerable<ContainerGroupResource>
    {
        private readonly ClientDiagnostics _containerGroupClientDiagnostics;
        private readonly ContainerGroupsRestOperations _containerGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupCollection"/> class for mocking. </summary>
        protected ContainerGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerGroupResource.ResourceType, out string containerGroupApiVersion);
            _containerGroupRestClient = new ContainerGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerGroupApiVersion);
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
        /// Create or update container groups with specified configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="data"> The properties of the container group to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerGroupName, ContainerGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerInstanceArmOperation<ContainerGroupResource>(new ContainerGroupOperationSource(Client), _containerGroupClientDiagnostics, Pipeline, _containerGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update container groups with specified configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="data"> The properties of the container group to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerGroupResource> CreateOrUpdate(WaitUntil waitUntil, string containerGroupName, ContainerGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, data, cancellationToken);
                var operation = new ContainerInstanceArmOperation<ContainerGroupResource>(new ContainerGroupOperationSource(Client), _containerGroupClientDiagnostics, Pipeline, _containerGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual async Task<Response<ContainerGroupResource>> GetAsync(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual Response<ContainerGroupResource> Get(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _containerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of container groups in a specified subscription and resource group. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupResource(Client, ContainerGroupData.DeserializeContainerGroupData(e)), _containerGroupClientDiagnostics, Pipeline, "ContainerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of container groups in a specified subscription and resource group. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupResource(Client, ContainerGroupData.DeserializeContainerGroupData(e)), _containerGroupClientDiagnostics, Pipeline, "ContainerGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerGroupResource>> GetIfExistsAsync(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        public virtual NullableResponse<ContainerGroupResource> GetIfExists(string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));

            using var scope = _containerGroupClientDiagnostics.CreateScope("ContainerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerGroupResource> IEnumerable<ContainerGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerGroupResource> IAsyncEnumerable<ContainerGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
