// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseWorkloadGroupResource
    {
        // Get a a workload group of a SQL Analytics pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAAWorkloadGroupOfASQLAnalyticsPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolWorkloadGroup.json
            // this example is just showing the usage of "SqlPoolWorkloadGroup_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "smallrc";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // invoke the operation
            SynapseWorkloadGroupResource result = await synapseWorkloadGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a workload group with all properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAWorkloadGroupWithAllPropertiesSpecified()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolWorkloadGroupMax.json
            // this example is just showing the usage of "SqlPoolWorkloadGroup_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "smallrc";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // invoke the operation
            SynapseWorkloadGroupData data = new SynapseWorkloadGroupData()
            {
                MinResourcePercent = 0,
                MaxResourcePercent = 100,
                MinResourcePercentPerRequest = 3,
                MaxResourcePercentPerRequest = 3,
                Importance = "normal",
                QueryExecutionTimeout = 0,
            };
            ArmOperation<SynapseWorkloadGroupResource> lro = await synapseWorkloadGroup.UpdateAsync(WaitUntil.Completed, data);
            SynapseWorkloadGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a workload group with the required properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAWorkloadGroupWithTheRequiredPropertiesSpecified()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolWorkloadGroupMin.json
            // this example is just showing the usage of "SqlPoolWorkloadGroup_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "smallrc";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // invoke the operation
            SynapseWorkloadGroupData data = new SynapseWorkloadGroupData()
            {
                MinResourcePercent = 0,
                MaxResourcePercent = 100,
                MinResourcePercentPerRequest = 3,
            };
            ArmOperation<SynapseWorkloadGroupResource> lro = await synapseWorkloadGroup.UpdateAsync(WaitUntil.Completed, data);
            SynapseWorkloadGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a workload group of a SQL Analytics pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAWorkloadGroupOfASQLAnalyticsPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DeleteSqlPoolWorkloadGroup.json
            // this example is just showing the usage of "SqlPoolWorkloadGroup_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // invoke the operation
            await synapseWorkloadGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
