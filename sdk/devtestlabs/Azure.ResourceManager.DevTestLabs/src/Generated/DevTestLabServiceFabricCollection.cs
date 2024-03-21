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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabServiceFabricResource"/> and their operations.
    /// Each <see cref="DevTestLabServiceFabricResource"/> in the collection will belong to the same instance of <see cref="DevTestLabUserResource"/>.
    /// To get a <see cref="DevTestLabServiceFabricCollection"/> instance call the GetDevTestLabServiceFabrics method from an instance of <see cref="DevTestLabUserResource"/>.
    /// </summary>
    public partial class DevTestLabServiceFabricCollection : ArmCollection, IEnumerable<DevTestLabServiceFabricResource>, IAsyncEnumerable<DevTestLabServiceFabricResource>
    {
        private readonly ClientDiagnostics _devTestLabServiceFabricServiceFabricsClientDiagnostics;
        private readonly ServiceFabricsRestOperations _devTestLabServiceFabricServiceFabricsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabServiceFabricCollection"/> class for mocking. </summary>
        protected DevTestLabServiceFabricCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabServiceFabricCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabServiceFabricCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabServiceFabricServiceFabricsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabServiceFabricResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabServiceFabricResource.ResourceType, out string devTestLabServiceFabricServiceFabricsApiVersion);
            _devTestLabServiceFabricServiceFabricsRestClient = new ServiceFabricsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabServiceFabricServiceFabricsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabUserResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabUserResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing service fabric. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="data"> A Service Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabServiceFabricResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabServiceFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceFabricServiceFabricsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabServiceFabricResource>(new DevTestLabServiceFabricOperationSource(Client), _devTestLabServiceFabricServiceFabricsClientDiagnostics, Pipeline, _devTestLabServiceFabricServiceFabricsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or replace an existing service fabric. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="data"> A Service Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabServiceFabricResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabServiceFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabServiceFabricServiceFabricsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabServiceFabricResource>(new DevTestLabServiceFabricOperationSource(Client), _devTestLabServiceFabricServiceFabricsClientDiagnostics, Pipeline, _devTestLabServiceFabricServiceFabricsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get service fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabServiceFabricResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceFabricServiceFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get service fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabServiceFabricResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabServiceFabricServiceFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List service fabrics in a given user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabServiceFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabServiceFabricResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabServiceFabricServiceFabricsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabServiceFabricServiceFabricsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabServiceFabricResource(Client, DevTestLabServiceFabricData.DeserializeDevTestLabServiceFabricData(e)), _devTestLabServiceFabricServiceFabricsClientDiagnostics, Pipeline, "DevTestLabServiceFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List service fabrics in a given user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabServiceFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabServiceFabricResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabServiceFabricServiceFabricsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabServiceFabricServiceFabricsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabServiceFabricResource(Client, DevTestLabServiceFabricData.DeserializeDevTestLabServiceFabricData(e)), _devTestLabServiceFabricServiceFabricsClientDiagnostics, Pipeline, "DevTestLabServiceFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceFabricServiceFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabServiceFabricServiceFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabServiceFabricResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabServiceFabricServiceFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabServiceFabricResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceFabricResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/servicefabrics/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceFabrics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabServiceFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the service fabric. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($expand=applicableSchedule)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabServiceFabricResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabServiceFabricServiceFabricsClientDiagnostics.CreateScope("DevTestLabServiceFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabServiceFabricServiceFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabServiceFabricResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabServiceFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabServiceFabricResource> IEnumerable<DevTestLabServiceFabricResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabServiceFabricResource> IAsyncEnumerable<DevTestLabServiceFabricResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
