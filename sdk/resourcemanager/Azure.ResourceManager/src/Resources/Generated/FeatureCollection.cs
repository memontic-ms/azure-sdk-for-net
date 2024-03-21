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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="FeatureResource"/> and their operations.
    /// Each <see cref="FeatureResource"/> in the collection will belong to the same instance of <see cref="ResourceProviderResource"/>.
    /// To get a <see cref="FeatureCollection"/> instance call the GetFeatures method from an instance of <see cref="ResourceProviderResource"/>.
    /// </summary>
    public partial class FeatureCollection : ArmCollection, IEnumerable<FeatureResource>, IAsyncEnumerable<FeatureResource>
    {
        private readonly ClientDiagnostics _featureClientDiagnostics;
        private readonly FeaturesRestOperations _featureRestClient;

        /// <summary> Initializes a new instance of the <see cref="FeatureCollection"/> class for mocking. </summary>
        protected FeatureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FeatureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FeatureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", FeatureResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FeatureResource.ResourceType, out string featureApiVersion);
            _featureRestClient = new FeaturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, featureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceProviderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceProviderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<FeatureResource>> GetAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Get");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.Provider, featureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<FeatureResource> Get(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Get");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.Provider, featureName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the preview features in a provider namespace that are available through AFEC for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FeatureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FeatureResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _featureRestClient.CreateListRequest(Id.SubscriptionId, Id.Provider);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featureRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Provider);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FeatureResource(Client, FeatureData.DeserializeFeatureData(e)), _featureClientDiagnostics, Pipeline, "FeatureCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the preview features in a provider namespace that are available through AFEC for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FeatureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FeatureResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _featureRestClient.CreateListRequest(Id.SubscriptionId, Id.Provider);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featureRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Provider);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FeatureResource(Client, FeatureData.DeserializeFeatureData(e)), _featureClientDiagnostics, Pipeline, "FeatureCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<bool> Exists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<NullableResponse<FeatureResource>> GetIfExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FeatureResource>(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual NullableResponse<FeatureResource> GetIfExists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _featureClientDiagnostics.CreateScope("FeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.Provider, featureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FeatureResource>(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FeatureResource> IEnumerable<FeatureResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FeatureResource> IAsyncEnumerable<FeatureResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
