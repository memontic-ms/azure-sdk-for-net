// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudAgentPoolCollection
    {
        // List agent pools of the Kubernetes cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAgentPoolsOfTheKubernetesCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/AgentPools_ListByKubernetesCluster.json
            // this example is just showing the usage of "AgentPools_ListByKubernetesCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudAgentPoolResource
            NetworkCloudAgentPoolCollection collection = networkCloudKubernetesCluster.GetNetworkCloudAgentPools();

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudAgentPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudAgentPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Kubernetes cluster agent pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/AgentPools_Get.json
            // this example is just showing the usage of "AgentPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudAgentPoolResource
            NetworkCloudAgentPoolCollection collection = networkCloudKubernetesCluster.GetNetworkCloudAgentPools();

            // invoke the operation
            string agentPoolName = "agentPoolName";
            NetworkCloudAgentPoolResource result = await collection.GetAsync(agentPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Kubernetes cluster agent pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/AgentPools_Get.json
            // this example is just showing the usage of "AgentPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudAgentPoolResource
            NetworkCloudAgentPoolCollection collection = networkCloudKubernetesCluster.GetNetworkCloudAgentPools();

            // invoke the operation
            string agentPoolName = "agentPoolName";
            bool result = await collection.ExistsAsync(agentPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Kubernetes cluster agent pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/AgentPools_Get.json
            // this example is just showing the usage of "AgentPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudAgentPoolResource
            NetworkCloudAgentPoolCollection collection = networkCloudKubernetesCluster.GetNetworkCloudAgentPools();

            // invoke the operation
            string agentPoolName = "agentPoolName";
            NullableResponse<NetworkCloudAgentPoolResource> response = await collection.GetIfExistsAsync(agentPoolName);
            NetworkCloudAgentPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudAgentPoolData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update Kubernetes cluster agent pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/AgentPools_Create.json
            // this example is just showing the usage of "AgentPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudAgentPoolResource
            NetworkCloudAgentPoolCollection collection = networkCloudKubernetesCluster.GetNetworkCloudAgentPools();

            // invoke the operation
            string agentPoolName = "agentPoolName";
            NetworkCloudAgentPoolData data = new NetworkCloudAgentPoolData(new AzureLocation("location"), 3, NetworkCloudAgentPoolMode.System, "NC_M16_v1")
            {
                ExtendedLocation = new ExtendedLocation("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.ExtendedLocation/customLocations/clusterExtendedLocationName", "CustomLocation"),
                AdministratorConfiguration = new AdministratorConfiguration()
                {
                    AdminUsername = "azure",
                    SshPublicKeys =
{
new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm")
},
                },
                AgentOptions = new NetworkCloudAgentConfiguration(96)
                {
                    HugepagesSize = HugepagesSize.OneG,
                },
                AttachedNetworkConfiguration = new AttachedNetworkConfiguration()
                {
                    L2Networks =
{
new L2NetworkAttachmentConfiguration(new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.NetworkCloud/l2Networks/l2NetworkName"))
{
PluginType = KubernetesPluginType.Dpdk,
}
},
                    L3Networks =
{
new L3NetworkAttachmentConfiguration(new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.NetworkCloud/l3Networks/l3NetworkName"))
{
IpamEnabled = L3NetworkConfigurationIpamEnabled.False,
PluginType = KubernetesPluginType.Sriov,
}
},
                    TrunkedNetworks =
{
new TrunkedNetworkAttachmentConfiguration(new ResourceIdentifier("/subscriptions/123e4567-e89b-12d3-a456-426655440000/resourceGroups/resourceGroupName/providers/Microsoft.NetworkCloud/trunkedNetworks/trunkedNetworkName"))
{
PluginType = KubernetesPluginType.Macvlan,
}
},
                },
                AvailabilityZones =
{
"1","2","3"
},
                Labels =
{
new KubernetesLabel("kubernetes.label","true")
},
                Taints =
{
new KubernetesLabel("kubernetes.taint","true")
},
                UpgradeMaxSurge = "1",
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
            };
            ArmOperation<NetworkCloudAgentPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, agentPoolName, data);
            NetworkCloudAgentPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
