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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A Class representing an AutomanageVmConfigurationProfileAssignmentReport along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomanageVmConfigurationProfileAssignmentReportResource method.
    /// Otherwise you can get one from its parent resource <see cref="AutomanageVmConfigurationProfileAssignmentResource"/> using the GetAutomanageVmConfigurationProfileAssignmentReport method.
    /// </summary>
    public partial class AutomanageVmConfigurationProfileAssignmentReportResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vmName"> The vmName. </param>
        /// <param name="configurationProfileAssignmentName"> The configurationProfileAssignmentName. </param>
        /// <param name="reportName"> The reportName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmName, string configurationProfileAssignmentName, string reportName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics;
        private readonly ReportsRestOperations _automanageVmConfigurationProfileAssignmentReportreportsRestClient;
        private readonly AutomanageConfigurationProfileAssignmentReportData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automanage/configurationProfileAssignments/reports";

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/> class for mocking. </summary>
        protected AutomanageVmConfigurationProfileAssignmentReportResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomanageVmConfigurationProfileAssignmentReportResource(ArmClient client, AutomanageConfigurationProfileAssignmentReportData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomanageVmConfigurationProfileAssignmentReportResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automanageVmConfigurationProfileAssignmentReportreportsApiVersion);
            _automanageVmConfigurationProfileAssignmentReportreportsRestClient = new ReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageVmConfigurationProfileAssignmentReportreportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomanageConfigurationProfileAssignmentReportData Data
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
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomanageVmConfigurationProfileAssignmentReportResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportResource.Get");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentReportreportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageVmConfigurationProfileAssignmentReportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomanageVmConfigurationProfileAssignmentReportResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportResource.Get");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentReportreportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
