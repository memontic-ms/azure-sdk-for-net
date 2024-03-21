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
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryWebhookResource"/> and their operations.
    /// Each <see cref="ContainerRegistryWebhookResource"/> in the collection will belong to the same instance of <see cref="ContainerRegistryResource"/>.
    /// To get a <see cref="ContainerRegistryWebhookCollection"/> instance call the GetContainerRegistryWebhooks method from an instance of <see cref="ContainerRegistryResource"/>.
    /// </summary>
    public partial class ContainerRegistryWebhookCollection : ArmCollection, IEnumerable<ContainerRegistryWebhookResource>, IAsyncEnumerable<ContainerRegistryWebhookResource>
    {
        private readonly ClientDiagnostics _containerRegistryWebhookWebhooksClientDiagnostics;
        private readonly WebhooksRestOperations _containerRegistryWebhookWebhooksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryWebhookCollection"/> class for mocking. </summary>
        protected ContainerRegistryWebhookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryWebhookCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryWebhookCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryWebhookWebhooksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryWebhookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryWebhookResource.ResourceType, out string containerRegistryWebhookWebhooksApiVersion);
            _containerRegistryWebhookWebhooksRestClient = new WebhooksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryWebhookWebhooksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a webhook for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="content"> The parameters for creating a webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryWebhookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string webhookName, ContainerRegistryWebhookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryWebhookWebhooksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryWebhookResource>(new ContainerRegistryWebhookOperationSource(Client), _containerRegistryWebhookWebhooksClientDiagnostics, Pipeline, _containerRegistryWebhookWebhooksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a webhook for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="content"> The parameters for creating a webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryWebhookResource> CreateOrUpdate(WaitUntil waitUntil, string webhookName, ContainerRegistryWebhookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryWebhookWebhooksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryWebhookResource>(new ContainerRegistryWebhookOperationSource(Client), _containerRegistryWebhookWebhooksClientDiagnostics, Pipeline, _containerRegistryWebhookWebhooksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the properties of the specified webhook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryWebhookResource>> GetAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryWebhookWebhooksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified webhook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<ContainerRegistryWebhookResource> Get(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryWebhookWebhooksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the webhooks for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryWebhookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryWebhookResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryWebhookWebhooksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryWebhookWebhooksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryWebhookResource(Client, ContainerRegistryWebhookData.DeserializeContainerRegistryWebhookData(e)), _containerRegistryWebhookWebhooksClientDiagnostics, Pipeline, "ContainerRegistryWebhookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the webhooks for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryWebhookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryWebhookResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryWebhookWebhooksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryWebhookWebhooksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryWebhookResource(Client, ContainerRegistryWebhookData.DeserializeContainerRegistryWebhookData(e)), _containerRegistryWebhookWebhooksClientDiagnostics, Pipeline, "ContainerRegistryWebhookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryWebhookWebhooksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<bool> Exists(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryWebhookWebhooksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerRegistryWebhookResource>> GetIfExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerRegistryWebhookWebhooksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryWebhookResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryWebhookResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryWebhookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual NullableResponse<ContainerRegistryWebhookResource> GetIfExists(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _containerRegistryWebhookWebhooksClientDiagnostics.CreateScope("ContainerRegistryWebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerRegistryWebhookWebhooksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryWebhookResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryWebhookResource> IEnumerable<ContainerRegistryWebhookResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryWebhookResource> IAsyncEnumerable<ContainerRegistryWebhookResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
