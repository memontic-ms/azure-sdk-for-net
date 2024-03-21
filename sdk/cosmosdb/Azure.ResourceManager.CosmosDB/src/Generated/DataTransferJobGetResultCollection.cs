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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="DataTransferJobGetResultResource"/> and their operations.
    /// Each <see cref="DataTransferJobGetResultResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="DataTransferJobGetResultCollection"/> instance call the GetDataTransferJobGetResults method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class DataTransferJobGetResultCollection : ArmCollection, IEnumerable<DataTransferJobGetResultResource>, IAsyncEnumerable<DataTransferJobGetResultResource>
    {
        private readonly ClientDiagnostics _dataTransferJobGetResultDataTransferJobsClientDiagnostics;
        private readonly DataTransferJobsRestOperations _dataTransferJobGetResultDataTransferJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataTransferJobGetResultCollection"/> class for mocking. </summary>
        protected DataTransferJobGetResultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataTransferJobGetResultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataTransferJobGetResultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataTransferJobGetResultDataTransferJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", DataTransferJobGetResultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataTransferJobGetResultResource.ResourceType, out string dataTransferJobGetResultDataTransferJobsApiVersion);
            _dataTransferJobGetResultDataTransferJobsRestClient = new DataTransferJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataTransferJobGetResultDataTransferJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Data Transfer Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="content"> The <see cref="DataTransferJobGetResultCreateOrUpdateContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataTransferJobGetResultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobName, DataTransferJobGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataTransferJobGetResultDataTransferJobsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DataTransferJobGetResultResource>(Response.FromValue(new DataTransferJobGetResultResource(Client, response), response.GetRawResponse()));
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
        /// Creates a Data Transfer Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="content"> The <see cref="DataTransferJobGetResultCreateOrUpdateContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataTransferJobGetResultResource> CreateOrUpdate(WaitUntil waitUntil, string jobName, DataTransferJobGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataTransferJobGetResultDataTransferJobsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<DataTransferJobGetResultResource>(Response.FromValue(new DataTransferJobGetResultResource(Client, response), response.GetRawResponse()));
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
        /// Get a Data Transfer Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<DataTransferJobGetResultResource>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataTransferJobGetResultDataTransferJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataTransferJobGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Data Transfer Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<DataTransferJobGetResultResource> Get(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = _dataTransferJobGetResultDataTransferJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataTransferJobGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Data Transfer jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_ListByDatabaseAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataTransferJobGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataTransferJobGetResultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataTransferJobGetResultDataTransferJobsRestClient.CreateListByDatabaseAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataTransferJobGetResultDataTransferJobsRestClient.CreateListByDatabaseAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataTransferJobGetResultResource(Client, DataTransferJobGetResultData.DeserializeDataTransferJobGetResultData(e)), _dataTransferJobGetResultDataTransferJobsClientDiagnostics, Pipeline, "DataTransferJobGetResultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Data Transfer jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_ListByDatabaseAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataTransferJobGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataTransferJobGetResultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataTransferJobGetResultDataTransferJobsRestClient.CreateListByDatabaseAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataTransferJobGetResultDataTransferJobsRestClient.CreateListByDatabaseAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataTransferJobGetResultResource(Client, DataTransferJobGetResultData.DeserializeDataTransferJobGetResultData(e)), _dataTransferJobGetResultDataTransferJobsClientDiagnostics, Pipeline, "DataTransferJobGetResultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataTransferJobGetResultDataTransferJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataTransferJobGetResultDataTransferJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataTransferJobGetResultResource>> GetIfExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataTransferJobGetResultDataTransferJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataTransferJobGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new DataTransferJobGetResultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/dataTransferJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataTransferJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataTransferJobGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Data Transfer Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual NullableResponse<DataTransferJobGetResultResource> GetIfExists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _dataTransferJobGetResultDataTransferJobsClientDiagnostics.CreateScope("DataTransferJobGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataTransferJobGetResultDataTransferJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataTransferJobGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new DataTransferJobGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataTransferJobGetResultResource> IEnumerable<DataTransferJobGetResultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataTransferJobGetResultResource> IAsyncEnumerable<DataTransferJobGetResultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
