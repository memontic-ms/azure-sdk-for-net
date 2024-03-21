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

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceFleetResource"/> and their operations.
    /// Each <see cref="ContainerServiceFleetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ContainerServiceFleetCollection"/> instance call the GetContainerServiceFleets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ContainerServiceFleetCollection : ArmCollection, IEnumerable<ContainerServiceFleetResource>, IAsyncEnumerable<ContainerServiceFleetResource>
    {
        private readonly ClientDiagnostics _containerServiceFleetFleetsClientDiagnostics;
        private readonly FleetsRestOperations _containerServiceFleetFleetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetCollection"/> class for mocking. </summary>
        protected ContainerServiceFleetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceFleetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceFleetFleetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ContainerServiceFleetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceFleetResource.ResourceType, out string containerServiceFleetFleetsApiVersion);
            _containerServiceFleetFleetsRestClient = new FleetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceFleetFleetsApiVersion);
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
        /// Creates or updates a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceFleetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fleetName, ContainerServiceFleetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetFleetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetResource>(new ContainerServiceFleetOperationSource(Client), _containerServiceFleetFleetsClientDiagnostics, Pipeline, _containerServiceFleetFleetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Creates or updates a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceFleetResource> CreateOrUpdate(WaitUntil waitUntil, string fleetName, ContainerServiceFleetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerServiceFleetFleetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetResource>(new ContainerServiceFleetOperationSource(Client), _containerServiceFleetFleetsClientDiagnostics, Pipeline, _containerServiceFleetFleetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceFleetResource>> GetAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual Response<ContainerServiceFleetResource> Get(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists fleets in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceFleetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceFleetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetFleetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetFleetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetResource(Client, ContainerServiceFleetData.DeserializeContainerServiceFleetData(e)), _containerServiceFleetFleetsClientDiagnostics, Pipeline, "ContainerServiceFleetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists fleets in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceFleetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceFleetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetFleetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetFleetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetResource(Client, ContainerServiceFleetData.DeserializeContainerServiceFleetData(e)), _containerServiceFleetFleetsClientDiagnostics, Pipeline, "ContainerServiceFleetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual Response<bool> Exists(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerServiceFleetResource>> GetIfExistsAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual NullableResponse<ContainerServiceFleetResource> GetIfExists(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _containerServiceFleetFleetsClientDiagnostics.CreateScope("ContainerServiceFleetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceFleetResource> IEnumerable<ContainerServiceFleetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceFleetResource> IAsyncEnumerable<ContainerServiceFleetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
