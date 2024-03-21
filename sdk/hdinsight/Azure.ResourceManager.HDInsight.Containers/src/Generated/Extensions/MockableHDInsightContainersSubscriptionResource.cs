// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HDInsight.Containers.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHDInsightContainersSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _hdInsightClusterPoolClusterPoolsClientDiagnostics;
        private ClusterPoolsRestOperations _hdInsightClusterPoolClusterPoolsRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;
        private ClientDiagnostics _availableClusterPoolVersionsClientDiagnostics;
        private AvailableClusterPoolVersionsRestOperations _availableClusterPoolVersionsRestClient;
        private ClientDiagnostics _availableClusterVersionsClientDiagnostics;
        private AvailableClusterVersionsRestOperations _availableClusterVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersSubscriptionResource"/> class for mocking. </summary>
        protected MockableHDInsightContainersSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHDInsightContainersSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HDInsightClusterPoolClusterPoolsClientDiagnostics => _hdInsightClusterPoolClusterPoolsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", HDInsightClusterPoolResource.ResourceType.Namespace, Diagnostics);
        private ClusterPoolsRestOperations HDInsightClusterPoolClusterPoolsRestClient => _hdInsightClusterPoolClusterPoolsRestClient ??= new ClusterPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HDInsightClusterPoolResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AvailableClusterPoolVersionsClientDiagnostics => _availableClusterPoolVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableClusterPoolVersionsRestOperations AvailableClusterPoolVersionsRestClient => _availableClusterPoolVersionsRestClient ??= new AvailableClusterPoolVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AvailableClusterVersionsClientDiagnostics => _availableClusterVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableClusterVersionsRestOperations AvailableClusterVersionsRestClient => _availableClusterVersionsRestClient ??= new AvailableClusterVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HDInsightClusterPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightClusterPoolResource> GetHDInsightClusterPoolsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HDInsightClusterPoolClusterPoolsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HDInsightClusterPoolClusterPoolsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HDInsightClusterPoolResource(Client, HDInsightClusterPoolData.DeserializeHDInsightClusterPoolData(e)), HDInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetHDInsightClusterPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HDInsightClusterPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightClusterPoolResource> GetHDInsightClusterPools(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HDInsightClusterPoolClusterPoolsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HDInsightClusterPoolClusterPoolsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HDInsightClusterPoolResource(Client, HDInsightClusterPoolData.DeserializeHDInsightClusterPoolData(e)), HDInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetHDInsightClusterPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<HDInsightNameAvailabilityResult>> CheckHDInsightNameAvailabilityAsync(AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LocationsClientDiagnostics.CreateScope("MockableHDInsightContainersSubscriptionResource.CheckHDInsightNameAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<HDInsightNameAvailabilityResult> CheckHDInsightNameAvailability(AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LocationsClientDiagnostics.CreateScope("MockableHDInsightContainersSubscriptionResource.CheckHDInsightNameAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterPoolVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterPoolVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterPoolVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ClusterPoolVersion.DeserializeClusterPoolVersion(e), AvailableClusterPoolVersionsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetAvailableClusterPoolVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterPoolVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterPoolVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterPoolVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ClusterPoolVersion.DeserializeClusterPoolVersion(e), AvailableClusterPoolVersionsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetAvailableClusterPoolVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightClusterVersion> GetAvailableClusterVersionsByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => HDInsightClusterVersion.DeserializeHDInsightClusterVersion(e), AvailableClusterVersionsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetAvailableClusterVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightClusterVersion> GetAvailableClusterVersionsByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => HDInsightClusterVersion.DeserializeHDInsightClusterVersion(e), AvailableClusterVersionsClientDiagnostics, Pipeline, "MockableHDInsightContainersSubscriptionResource.GetAvailableClusterVersionsByLocation", "value", "nextLink", cancellationToken);
        }
    }
}
