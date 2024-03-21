// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.LabServices.Models;

namespace Azure.ResourceManager.LabServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableLabServicesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _labPlanClientDiagnostics;
        private LabPlansRestOperations _labPlanRestClient;
        private ClientDiagnostics _labClientDiagnostics;
        private LabsRestOperations _labRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableLabServicesSubscriptionResource"/> class for mocking. </summary>
        protected MockableLabServicesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableLabServicesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableLabServicesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LabPlanClientDiagnostics => _labPlanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.LabServices", LabPlanResource.ResourceType.Namespace, Diagnostics);
        private LabPlansRestOperations LabPlanRestClient => _labPlanRestClient ??= new LabPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LabPlanResource.ResourceType));
        private ClientDiagnostics LabClientDiagnostics => _labClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.LabServices", LabResource.ResourceType.Namespace, Diagnostics);
        private LabsRestOperations LabRestClient => _labRestClient ??= new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LabResource.ResourceType));
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.LabServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.LabServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns a list of all lab plans within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabPlanResource> GetLabPlansAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LabPlanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LabPlanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LabPlanResource(Client, LabPlanData.DeserializeLabPlanData(e)), LabPlanClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetLabPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of all lab plans within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabPlanResource> GetLabPlans(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LabPlanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LabPlanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LabPlanResource(Client, LabPlanData.DeserializeLabPlanData(e)), LabPlanClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetLabPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of all labs for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabResource> GetLabsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LabRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LabRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LabResource(Client, LabData.DeserializeLabData(e)), LabClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetLabs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of all labs for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabResource> GetLabs(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LabRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LabRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LabResource(Client, LabData.DeserializeLabData(e)), LabClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetLabs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure Lab Services resource SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableLabServicesSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableLabServicesSku> GetSkusAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => AvailableLabServicesSku.DeserializeAvailableLabServicesSku(e), SkusClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure Lab Services resource SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableLabServicesSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableLabServicesSku> GetSkus(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => AvailableLabServicesSku.DeserializeAvailableLabServicesSku(e), SkusClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of usage per SKU family for the specified subscription in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location name. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabServicesUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabServicesUsage> GetUsagesAsync(AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => LabServicesUsage.DeserializeLabServicesUsage(e), UsagesClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of usage per SKU family for the specified subscription in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location name. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabServicesUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabServicesUsage> GetUsages(AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => LabServicesUsage.DeserializeLabServicesUsage(e), UsagesClientDiagnostics, Pipeline, "MockableLabServicesSubscriptionResource.GetUsages", "value", "nextLink", cancellationToken);
        }
    }
}
