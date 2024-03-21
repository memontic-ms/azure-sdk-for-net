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

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceHealthEventResource"/> and their operations.
    /// Each <see cref="ResourceHealthEventResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="ResourceHealthEventCollection"/> instance call the GetResourceHealthEvents method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ResourceHealthEventCollection : ArmCollection, IEnumerable<ResourceHealthEventResource>, IAsyncEnumerable<ResourceHealthEventResource>
    {
        private readonly ClientDiagnostics _resourceHealthEventEventClientDiagnostics;
        private readonly EventRestOperations _resourceHealthEventEventRestClient;
        private readonly ClientDiagnostics _resourceHealthEventEventsClientDiagnostics;
        private readonly EventsRestOperations _resourceHealthEventEventsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventCollection"/> class for mocking. </summary>
        protected ResourceHealthEventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceHealthEventCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceHealthEventEventClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceHealthEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceHealthEventResource.ResourceType, out string resourceHealthEventEventApiVersion);
            _resourceHealthEventEventRestClient = new EventRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthEventEventApiVersion);
            _resourceHealthEventEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceHealthEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceHealthEventResource.ResourceType, out string resourceHealthEventEventsApiVersion);
            _resourceHealthEventEventsRestClient = new EventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthEventEventsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual async Task<Response<ResourceHealthEventResource>> GetAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual Response<ResourceHealthEventResource> Get(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists service health events in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthEventResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthEventResource> GetAllAsync(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceHealthEventEventsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, queryStartTime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceHealthEventEventsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, queryStartTime);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceHealthEventResource(Client, ResourceHealthEventData.DeserializeResourceHealthEventData(e)), _resourceHealthEventEventsClientDiagnostics, Pipeline, "ResourceHealthEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists service health events in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthEventResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthEventResource> GetAll(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceHealthEventEventsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, queryStartTime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceHealthEventEventsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, queryStartTime);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceHealthEventResource(Client, ResourceHealthEventData.DeserializeResourceHealthEventData(e)), _resourceHealthEventEventsClientDiagnostics, Pipeline, "ResourceHealthEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual Response<bool> Exists(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceHealthEventResource>> GetIfExistsAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceHealthEventResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual NullableResponse<ResourceHealthEventResource> GetIfExists(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceHealthEventResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceHealthEventResource> IEnumerable<ResourceHealthEventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceHealthEventResource> IAsyncEnumerable<ResourceHealthEventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
