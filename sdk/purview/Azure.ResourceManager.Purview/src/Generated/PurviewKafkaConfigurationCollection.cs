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

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A class representing a collection of <see cref="PurviewKafkaConfigurationResource"/> and their operations.
    /// Each <see cref="PurviewKafkaConfigurationResource"/> in the collection will belong to the same instance of <see cref="PurviewAccountResource"/>.
    /// To get a <see cref="PurviewKafkaConfigurationCollection"/> instance call the GetPurviewKafkaConfigurations method from an instance of <see cref="PurviewAccountResource"/>.
    /// </summary>
    public partial class PurviewKafkaConfigurationCollection : ArmCollection, IEnumerable<PurviewKafkaConfigurationResource>, IAsyncEnumerable<PurviewKafkaConfigurationResource>
    {
        private readonly ClientDiagnostics _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics;
        private readonly KafkaConfigurationsRestOperations _purviewKafkaConfigurationKafkaConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PurviewKafkaConfigurationCollection"/> class for mocking. </summary>
        protected PurviewKafkaConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PurviewKafkaConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PurviewKafkaConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Purview", PurviewKafkaConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PurviewKafkaConfigurationResource.ResourceType, out string purviewKafkaConfigurationKafkaConfigurationsApiVersion);
            _purviewKafkaConfigurationKafkaConfigurationsRestClient = new KafkaConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, purviewKafkaConfigurationKafkaConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PurviewAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PurviewAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update Kafka Configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kafkaConfigurationName"> The kafka configuration name. </param>
        /// <param name="data"> The kafka configuration of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PurviewKafkaConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string kafkaConfigurationName, PurviewKafkaConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PurviewArmOperation<PurviewKafkaConfigurationResource>(Response.FromValue(new PurviewKafkaConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Create or update Kafka Configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kafkaConfigurationName"> The kafka configuration name. </param>
        /// <param name="data"> The kafka configuration of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PurviewKafkaConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string kafkaConfigurationName, PurviewKafkaConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, data, cancellationToken);
                var operation = new PurviewArmOperation<PurviewKafkaConfigurationResource>(Response.FromValue(new PurviewKafkaConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Gets the kafka configuration for the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual async Task<Response<PurviewKafkaConfigurationResource>> GetAsync(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _purviewKafkaConfigurationKafkaConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewKafkaConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the kafka configuration for the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual Response<PurviewKafkaConfigurationResource> Get(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _purviewKafkaConfigurationKafkaConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewKafkaConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Kafka configurations in the Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PurviewKafkaConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PurviewKafkaConfigurationResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PurviewKafkaConfigurationResource(Client, PurviewKafkaConfigurationData.DeserializePurviewKafkaConfigurationData(e)), _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics, Pipeline, "PurviewKafkaConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Kafka configurations in the Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PurviewKafkaConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PurviewKafkaConfigurationResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewKafkaConfigurationKafkaConfigurationsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PurviewKafkaConfigurationResource(Client, PurviewKafkaConfigurationData.DeserializePurviewKafkaConfigurationData(e)), _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics, Pipeline, "PurviewKafkaConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _purviewKafkaConfigurationKafkaConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _purviewKafkaConfigurationKafkaConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<PurviewKafkaConfigurationResource>> GetIfExistsAsync(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _purviewKafkaConfigurationKafkaConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PurviewKafkaConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new PurviewKafkaConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/kafkaConfigurations/{kafkaConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KafkaConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewKafkaConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kafkaConfigurationName"> Name of kafka configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kafkaConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kafkaConfigurationName"/> is null. </exception>
        public virtual NullableResponse<PurviewKafkaConfigurationResource> GetIfExists(string kafkaConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kafkaConfigurationName, nameof(kafkaConfigurationName));

            using var scope = _purviewKafkaConfigurationKafkaConfigurationsClientDiagnostics.CreateScope("PurviewKafkaConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _purviewKafkaConfigurationKafkaConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kafkaConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PurviewKafkaConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new PurviewKafkaConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PurviewKafkaConfigurationResource> IEnumerable<PurviewKafkaConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PurviewKafkaConfigurationResource> IAsyncEnumerable<PurviewKafkaConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
