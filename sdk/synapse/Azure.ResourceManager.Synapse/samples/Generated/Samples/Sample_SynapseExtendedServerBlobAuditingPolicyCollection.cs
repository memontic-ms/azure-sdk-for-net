// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseExtendedServerBlobAuditingPolicyCollection
    {
        // Get workspace managed sql servers' extended blob auditing settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceManagedSqlServersExtendedBlobAuditingSettings()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlExtendedServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseExtendedServerBlobAuditingPolicyResource result = await collection.GetAsync(blobAuditingPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get workspace managed sql servers' extended blob auditing settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspaceManagedSqlServersExtendedBlobAuditingSettings()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlExtendedServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            bool result = await collection.ExistsAsync(blobAuditingPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get workspace managed sql servers' extended blob auditing settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWorkspaceManagedSqlServersExtendedBlobAuditingSettings()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlExtendedServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            NullableResponse<SynapseExtendedServerBlobAuditingPolicyResource> response = await collection.GetIfExistsAsync(blobAuditingPolicyName);
            SynapseExtendedServerBlobAuditingPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseExtendedServerBlobAuditingPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update workspace managed sql server's extended blob auditing policy of with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceManagedSqlServerSExtendedBlobAuditingPolicyOfWithAllParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerExtendedBlobAuditingSettingsWithAllParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseExtendedServerBlobAuditingPolicyData data = new SynapseExtendedServerBlobAuditingPolicyData()
            {
                PredicateExpression = "object_name = 'SensitiveData'",
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
                AuditActionsAndGroups =
{
"SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP","FAILED_DATABASE_AUTHENTICATION_GROUP","BATCH_COMPLETED_GROUP"
},
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
            };
            ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            SynapseExtendedServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update workspace managed sql server's extended blob auditing policy of with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceManagedSqlServerSExtendedBlobAuditingPolicyOfWithMinimalParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerExetendedBlobAuditingSettingsWithMinParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseExtendedServerBlobAuditingPolicyData data = new SynapseExtendedServerBlobAuditingPolicyData()
            {
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            SynapseExtendedServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get workspace managed sql server's extended blob auditing settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetWorkspaceManagedSqlServerSExtendedBlobAuditingSettings()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/ListWorkspaceManagedSqlServerExtendedBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseExtendedServerBlobAuditingPolicyResource
            SynapseExtendedServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseExtendedServerBlobAuditingPolicies();

            // invoke the operation and iterate over the result
            await foreach (SynapseExtendedServerBlobAuditingPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseExtendedServerBlobAuditingPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
