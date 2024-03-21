// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing an AvsPrivateCloudClusterVirtualMachine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AvsPrivateCloudClusterVirtualMachineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAvsPrivateCloudClusterVirtualMachineResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudClusterResource"/> using the GetAvsPrivateCloudClusterVirtualMachine method.
    /// </summary>
    public partial class AvsPrivateCloudClusterVirtualMachineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="privateCloudName"> The privateCloudName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="virtualMachineId"> The virtualMachineId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics;
        private readonly VirtualMachinesRestOperations _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient;
        private readonly AvsPrivateCloudClusterVirtualMachineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/clusters/virtualMachines";

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> class for mocking. </summary>
        protected AvsPrivateCloudClusterVirtualMachineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AvsPrivateCloudClusterVirtualMachineResource(ArmClient client, AvsPrivateCloudClusterVirtualMachineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudClusterVirtualMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AvsPrivateCloudClusterVirtualMachineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string avsPrivateCloudClusterVirtualMachineVirtualMachinesApiVersion);
            _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient = new VirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudClusterVirtualMachineVirtualMachinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AvsPrivateCloudClusterVirtualMachineData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudClusterVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvsPrivateCloudClusterVirtualMachineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineResource.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudClusterVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvsPrivateCloudClusterVirtualMachineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineResource.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudClusterVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enable or disable DRS-driven VM movement restriction
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}/restrictMovement</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_RestrictMovement</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudClusterVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restrictMovement"> Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restrictMovement"/> is null. </exception>
        public virtual async Task<ArmOperation> RestrictMovementAsync(WaitUntil waitUntil, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(restrictMovement, nameof(restrictMovement));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineResource.RestrictMovement");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.RestrictMovementAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, restrictMovement, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation(_avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateRestrictMovementRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, restrictMovement).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enable or disable DRS-driven VM movement restriction
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/virtualMachines/{virtualMachineId}/restrictMovement</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_RestrictMovement</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudClusterVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restrictMovement"> Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restrictMovement"/> is null. </exception>
        public virtual ArmOperation RestrictMovement(WaitUntil waitUntil, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(restrictMovement, nameof(restrictMovement));

            using var scope = _avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("AvsPrivateCloudClusterVirtualMachineResource.RestrictMovement");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.RestrictMovement(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, restrictMovement, cancellationToken);
                var operation = new AvsArmOperation(_avsPrivateCloudClusterVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, _avsPrivateCloudClusterVirtualMachineVirtualMachinesRestClient.CreateRestrictMovementRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, restrictMovement).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
