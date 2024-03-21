// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_NetworkInterfaceResource
    {
        // GetNetworkInterface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkInterface()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2023-09-01-preview/examples/GetNetworkInterface.json
            // this example is just showing the usage of "NetworkInterfaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string networkInterfaceName = "test-nic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // invoke the operation
            NetworkInterfaceResource result = await networkInterface.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteNetworkInterface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkInterface()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2023-09-01-preview/examples/DeleteNetworkInterface.json
            // this example is just showing the usage of "NetworkInterfaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string networkInterfaceName = "test-nic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // invoke the operation
            await networkInterface.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateNetworkInterface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateNetworkInterface()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2023-09-01-preview/examples/UpdateNetworkInterface.json
            // this example is just showing the usage of "NetworkInterfaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string networkInterfaceName = "test-nic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // invoke the operation
            NetworkInterfacePatch patch = new NetworkInterfacePatch()
            {
                Tags =
{
["additionalProperties"] = "sample",
},
            };
            ArmOperation<NetworkInterfaceResource> lro = await networkInterface.UpdateAsync(WaitUntil.Completed, patch);
            NetworkInterfaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListNetworkInterfaceBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkInterfaces_ListNetworkInterfaceBySubscription()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/preview/2023-09-01-preview/examples/ListNetworkInterfaceBySubscription.json
            // this example is just showing the usage of "NetworkInterfaces_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkInterfaceResource item in subscriptionResource.GetNetworkInterfacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
