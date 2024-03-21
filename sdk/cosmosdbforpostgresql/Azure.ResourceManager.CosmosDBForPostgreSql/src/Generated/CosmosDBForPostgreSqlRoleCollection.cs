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

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBForPostgreSqlRoleResource"/> and their operations.
    /// Each <see cref="CosmosDBForPostgreSqlRoleResource"/> in the collection will belong to the same instance of <see cref="CosmosDBForPostgreSqlClusterResource"/>.
    /// To get a <see cref="CosmosDBForPostgreSqlRoleCollection"/> instance call the GetCosmosDBForPostgreSqlRoles method from an instance of <see cref="CosmosDBForPostgreSqlClusterResource"/>.
    /// </summary>
    public partial class CosmosDBForPostgreSqlRoleCollection : ArmCollection, IEnumerable<CosmosDBForPostgreSqlRoleResource>, IAsyncEnumerable<CosmosDBForPostgreSqlRoleResource>
    {
        private readonly ClientDiagnostics _cosmosDBForPostgreSqlRoleRolesClientDiagnostics;
        private readonly RolesRestOperations _cosmosDBForPostgreSqlRoleRolesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlRoleCollection"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlRoleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlRoleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlRoleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlRoleRolesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlRoleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBForPostgreSqlRoleResource.ResourceType, out string cosmosDBForPostgreSqlRoleRolesApiVersion);
            _cosmosDBForPostgreSqlRoleRolesRestClient = new RolesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlRoleRolesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBForPostgreSqlClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBForPostgreSqlClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new role or updates an existing role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="data"> The required parameters for creating or updating a role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBForPostgreSqlRoleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleName, CosmosDBForPostgreSqlRoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlRoleRolesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlRoleResource>(new CosmosDBForPostgreSqlRoleOperationSource(Client), _cosmosDBForPostgreSqlRoleRolesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlRoleRolesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new role or updates an existing role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="data"> The required parameters for creating or updating a role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBForPostgreSqlRoleResource> CreateOrUpdate(WaitUntil waitUntil, string roleName, CosmosDBForPostgreSqlRoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlRoleRolesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, data, cancellationToken);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlRoleResource>(new CosmosDBForPostgreSqlRoleOperationSource(Client), _cosmosDBForPostgreSqlRoleRolesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlRoleRolesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a cluster role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlRoleResource>> GetAsync(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlRoleRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a cluster role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlRoleResource> Get(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlRoleRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the roles in a given cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlRoleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBForPostgreSqlRoleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlRoleRolesRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlRoleResource(Client, CosmosDBForPostgreSqlRoleData.DeserializeCosmosDBForPostgreSqlRoleData(e)), _cosmosDBForPostgreSqlRoleRolesClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlRoleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the roles in a given cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlRoleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBForPostgreSqlRoleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlRoleRolesRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlRoleResource(Client, CosmosDBForPostgreSqlRoleData.DeserializeCosmosDBForPostgreSqlRoleData(e)), _cosmosDBForPostgreSqlRoleRolesClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlRoleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlRoleRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlRoleRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBForPostgreSqlRoleResource>> GetIfExistsAsync(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlRoleRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlRoleResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlRoleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Roles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBForPostgreSqlRoleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleName"> The name of the cluster role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBForPostgreSqlRoleResource> GetIfExists(string roleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleName, nameof(roleName));

            using var scope = _cosmosDBForPostgreSqlRoleRolesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlRoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlRoleRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlRoleResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBForPostgreSqlRoleResource> IEnumerable<CosmosDBForPostgreSqlRoleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBForPostgreSqlRoleResource> IAsyncEnumerable<CosmosDBForPostgreSqlRoleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
