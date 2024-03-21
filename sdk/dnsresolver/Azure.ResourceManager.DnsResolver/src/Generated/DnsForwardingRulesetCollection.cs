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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsForwardingRulesetResource"/> and their operations.
    /// Each <see cref="DnsForwardingRulesetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DnsForwardingRulesetCollection"/> instance call the GetDnsForwardingRulesets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DnsForwardingRulesetCollection : ArmCollection, IEnumerable<DnsForwardingRulesetResource>, IAsyncEnumerable<DnsForwardingRulesetResource>
    {
        private readonly ClientDiagnostics _dnsForwardingRulesetClientDiagnostics;
        private readonly DnsForwardingRulesetsRestOperations _dnsForwardingRulesetRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetCollection"/> class for mocking. </summary>
        protected DnsForwardingRulesetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsForwardingRulesetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsForwardingRulesetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsForwardingRulesetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsForwardingRulesetResource.ResourceType, out string dnsForwardingRulesetApiVersion);
            _dnsForwardingRulesetRestClient = new DnsForwardingRulesetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsForwardingRulesetApiVersion);
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
        /// Creates or updates a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsForwardingRulesetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string rulesetName, DnsForwardingRulesetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetResource>(new DnsForwardingRulesetOperationSource(Client), _dnsForwardingRulesetClientDiagnostics, Pipeline, _dnsForwardingRulesetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsForwardingRulesetResource> CreateOrUpdate(WaitUntil waitUntil, string rulesetName, DnsForwardingRulesetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetResource>(new DnsForwardingRulesetOperationSource(Client), _dnsForwardingRulesetClientDiagnostics, Pipeline, _dnsForwardingRulesetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a DNS forwarding ruleset properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual async Task<Response<DnsForwardingRulesetResource>> GetAsync(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a DNS forwarding ruleset properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual Response<DnsForwardingRulesetResource> Get(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists DNS forwarding rulesets within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsForwardingRulesetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsForwardingRulesetResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsForwardingRulesetResource(Client, DnsForwardingRulesetData.DeserializeDnsForwardingRulesetData(e)), _dnsForwardingRulesetClientDiagnostics, Pipeline, "DnsForwardingRulesetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS forwarding rulesets within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsForwardingRulesetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsForwardingRulesetResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsForwardingRulesetResource(Client, DnsForwardingRulesetData.DeserializeDnsForwardingRulesetData(e)), _dnsForwardingRulesetClientDiagnostics, Pipeline, "DnsForwardingRulesetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual Response<bool> Exists(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DnsForwardingRulesetResource>> GetIfExistsAsync(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DnsForwardingRulesetResource>(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rulesetName"> The name of the DNS forwarding ruleset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rulesetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesetName"/> is null. </exception>
        public virtual NullableResponse<DnsForwardingRulesetResource> GetIfExists(string rulesetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rulesetName, nameof(rulesetName));

            using var scope = _dnsForwardingRulesetClientDiagnostics.CreateScope("DnsForwardingRulesetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rulesetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DnsForwardingRulesetResource>(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsForwardingRulesetResource> IEnumerable<DnsForwardingRulesetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsForwardingRulesetResource> IAsyncEnumerable<DnsForwardingRulesetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
