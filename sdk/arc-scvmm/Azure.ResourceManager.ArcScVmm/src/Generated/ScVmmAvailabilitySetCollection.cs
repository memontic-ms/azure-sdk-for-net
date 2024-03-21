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

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmAvailabilitySetResource"/> and their operations.
    /// Each <see cref="ScVmmAvailabilitySetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ScVmmAvailabilitySetCollection"/> instance call the GetScVmmAvailabilitySets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ScVmmAvailabilitySetCollection : ArmCollection, IEnumerable<ScVmmAvailabilitySetResource>, IAsyncEnumerable<ScVmmAvailabilitySetResource>
    {
        private readonly ClientDiagnostics _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics;
        private readonly AvailabilitySetsRestOperations _scVmmAvailabilitySetAvailabilitySetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmAvailabilitySetCollection"/> class for mocking. </summary>
        protected ScVmmAvailabilitySetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmAvailabilitySetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmAvailabilitySetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ScVmmAvailabilitySetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmAvailabilitySetResource.ResourceType, out string scVmmAvailabilitySetAvailabilitySetsApiVersion);
            _scVmmAvailabilitySetAvailabilitySetsRestClient = new AvailabilitySetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmAvailabilitySetAvailabilitySetsApiVersion);
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
        /// Onboards the ScVmm availability set as an Azure resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmAvailabilitySetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string availabilitySetName, ScVmmAvailabilitySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<ScVmmAvailabilitySetResource>(new ScVmmAvailabilitySetOperationSource(Client), _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics, Pipeline, _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Onboards the ScVmm availability set as an Azure resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmAvailabilitySetResource> CreateOrUpdate(WaitUntil waitUntil, string availabilitySetName, ScVmmAvailabilitySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<ScVmmAvailabilitySetResource>(new ScVmmAvailabilitySetOperationSource(Client), _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics, Pipeline, _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements AvailabilitySet GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<Response<ScVmmAvailabilitySetResource>> GetAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmAvailabilitySetAvailabilitySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmAvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements AvailabilitySet GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<ScVmmAvailabilitySetResource> Get(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmAvailabilitySetAvailabilitySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmAvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of AvailabilitySets in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmAvailabilitySetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmAvailabilitySetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmAvailabilitySetResource(Client, ScVmmAvailabilitySetData.DeserializeScVmmAvailabilitySetData(e)), _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics, Pipeline, "ScVmmAvailabilitySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of AvailabilitySets in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmAvailabilitySetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmAvailabilitySetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmAvailabilitySetAvailabilitySetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmAvailabilitySetResource(Client, ScVmmAvailabilitySetData.DeserializeScVmmAvailabilitySetData(e)), _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics, Pipeline, "ScVmmAvailabilitySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmAvailabilitySetAvailabilitySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmAvailabilitySetAvailabilitySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScVmmAvailabilitySetResource>> GetIfExistsAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scVmmAvailabilitySetAvailabilitySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmAvailabilitySetResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmAvailabilitySetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmAvailabilitySetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual NullableResponse<ScVmmAvailabilitySetResource> GetIfExists(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _scVmmAvailabilitySetAvailabilitySetsClientDiagnostics.CreateScope("ScVmmAvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scVmmAvailabilitySetAvailabilitySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmAvailabilitySetResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmAvailabilitySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmAvailabilitySetResource> IEnumerable<ScVmmAvailabilitySetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmAvailabilitySetResource> IAsyncEnumerable<ScVmmAvailabilitySetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
