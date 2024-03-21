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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsResolverInboundEndpointResource"/> and their operations.
    /// Each <see cref="DnsResolverInboundEndpointResource"/> in the collection will belong to the same instance of <see cref="DnsResolverResource"/>.
    /// To get a <see cref="DnsResolverInboundEndpointCollection"/> instance call the GetDnsResolverInboundEndpoints method from an instance of <see cref="DnsResolverResource"/>.
    /// </summary>
    public partial class DnsResolverInboundEndpointCollection : ArmCollection, IEnumerable<DnsResolverInboundEndpointResource>, IAsyncEnumerable<DnsResolverInboundEndpointResource>
    {
        private readonly ClientDiagnostics _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics;
        private readonly InboundEndpointsRestOperations _dnsResolverInboundEndpointInboundEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsResolverInboundEndpointCollection"/> class for mocking. </summary>
        protected DnsResolverInboundEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsResolverInboundEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsResolverInboundEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverInboundEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverInboundEndpointResource.ResourceType, out string dnsResolverInboundEndpointInboundEndpointsApiVersion);
            _dnsResolverInboundEndpointInboundEndpointsRestClient = new InboundEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverInboundEndpointInboundEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsResolverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsResolverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an inbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsResolverInboundEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inboundEndpointName, DnsResolverInboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsResolverInboundEndpointResource>(new DnsResolverInboundEndpointOperationSource(Client), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an inbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsResolverInboundEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string inboundEndpointName, DnsResolverInboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsResolverInboundEndpointResource>(new DnsResolverInboundEndpointOperationSource(Client), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of an inbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<DnsResolverInboundEndpointResource>> GetAsync(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of an inbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual Response<DnsResolverInboundEndpointResource> Get(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists inbound endpoints for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsResolverInboundEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsResolverInboundEndpointResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsResolverInboundEndpointResource(Client, DnsResolverInboundEndpointData.DeserializeDnsResolverInboundEndpointData(e)), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, "DnsResolverInboundEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists inbound endpoints for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsResolverInboundEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsResolverInboundEndpointResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsResolverInboundEndpointResource(Client, DnsResolverInboundEndpointData.DeserializeDnsResolverInboundEndpointData(e)), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, "DnsResolverInboundEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<DnsResolverInboundEndpointResource>> GetIfExistsAsync(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DnsResolverInboundEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverInboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual NullableResponse<DnsResolverInboundEndpointResource> GetIfExists(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DnsResolverInboundEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsResolverInboundEndpointResource> IEnumerable<DnsResolverInboundEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsResolverInboundEndpointResource> IAsyncEnumerable<DnsResolverInboundEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
