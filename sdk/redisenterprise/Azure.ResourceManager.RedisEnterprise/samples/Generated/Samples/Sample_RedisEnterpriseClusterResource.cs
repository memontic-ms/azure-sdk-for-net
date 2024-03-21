// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RedisEnterprise.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_RedisEnterpriseClusterResource
    {
        // RedisEnterpriseUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RedisEnterpriseUpdate()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2024-02-01/examples/RedisEnterpriseUpdate.json
            // this example is just showing the usage of "RedisEnterprise_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // invoke the operation
            RedisEnterpriseClusterPatch patch = new RedisEnterpriseClusterPatch()
            {
                Sku = new RedisEnterpriseSku(RedisEnterpriseSkuName.EnterpriseFlashF300)
                {
                    Capacity = 9,
                },
                Tags =
{
["tag1"] = "value1",
},
                MinimumTlsVersion = RedisEnterpriseTlsVersion.Tls1_2,
            };
            ArmOperation<RedisEnterpriseClusterResource> lro = await redisEnterpriseCluster.UpdateAsync(WaitUntil.Completed, patch);
            RedisEnterpriseClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RedisEnterpriseDelete()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2024-02-01/examples/RedisEnterpriseDelete.json
            // this example is just showing the usage of "RedisEnterprise_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // invoke the operation
            await redisEnterpriseCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RedisEnterpriseGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RedisEnterpriseGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2024-02-01/examples/RedisEnterpriseGet.json
            // this example is just showing the usage of "RedisEnterprise_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // invoke the operation
            RedisEnterpriseClusterResource result = await redisEnterpriseCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRedisEnterpriseClusters_RedisEnterpriseList()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2024-02-01/examples/RedisEnterpriseList.json
            // this example is just showing the usage of "RedisEnterprise_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (RedisEnterpriseClusterResource item in subscriptionResource.GetRedisEnterpriseClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisEnterpriseClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // RedisEnterpriseListPrivateLinkResources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResourcesByCluster_RedisEnterpriseListPrivateLinkResources()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2024-02-01/examples/RedisEnterpriseListPrivateLinkResources.json
            // this example is just showing the usage of "PrivateLinkResources_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // invoke the operation and iterate over the result
            await foreach (RedisEnterprisePrivateLinkResource item in redisEnterpriseCluster.GetPrivateLinkResourcesByClusterAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
