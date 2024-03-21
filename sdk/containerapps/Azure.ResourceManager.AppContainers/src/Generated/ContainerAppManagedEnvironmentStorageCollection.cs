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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppManagedEnvironmentStorageResource"/> and their operations.
    /// Each <see cref="ContainerAppManagedEnvironmentStorageResource"/> in the collection will belong to the same instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppManagedEnvironmentStorageCollection"/> instance call the GetContainerAppManagedEnvironmentStorages method from an instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentStorageCollection : ArmCollection, IEnumerable<ContainerAppManagedEnvironmentStorageResource>, IAsyncEnumerable<ContainerAppManagedEnvironmentStorageResource>
    {
        private readonly ClientDiagnostics _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics;
        private readonly ManagedEnvironmentsStoragesRestOperations _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentStorageCollection"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentStorageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentStorageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentStorageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedEnvironmentStorageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppManagedEnvironmentStorageResource.ResourceType, out string containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesApiVersion);
            _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient = new ManagedEnvironmentsStoragesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update storage for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppManagedEnvironmentStorageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageName, ContainerAppManagedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentStorageResource>(Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
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
        /// Create or update storage for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppManagedEnvironmentStorageResource> CreateOrUpdate(WaitUntil waitUntil, string storageName, ContainerAppManagedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentStorageResource>(Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
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
        /// Get storage for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppManagedEnvironmentStorageResource>> GetAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get storage for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<ContainerAppManagedEnvironmentStorageResource> Get(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all storages for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedEnvironmentStorageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedEnvironmentStorageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ContainerAppManagedEnvironmentStorageResource(Client, ContainerAppManagedEnvironmentStorageData.DeserializeContainerAppManagedEnvironmentStorageData(e)), _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentStorageCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all storages for a managedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedEnvironmentStorageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedEnvironmentStorageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ContainerAppManagedEnvironmentStorageResource(Client, ContainerAppManagedEnvironmentStorageData.DeserializeContainerAppManagedEnvironmentStorageData(e)), _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentStorageCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppManagedEnvironmentStorageResource>> GetIfExistsAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentStorageResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/storages/{storageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsStorages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentStorageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppManagedEnvironmentStorageResource> GetIfExists(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentStorageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentStorageManagedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentStorageResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppManagedEnvironmentStorageResource> IEnumerable<ContainerAppManagedEnvironmentStorageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppManagedEnvironmentStorageResource> IAsyncEnumerable<ContainerAppManagedEnvironmentStorageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
