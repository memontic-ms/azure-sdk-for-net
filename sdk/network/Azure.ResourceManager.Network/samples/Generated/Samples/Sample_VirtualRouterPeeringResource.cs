// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualRouterPeeringResource
    {
        // Delete VirtualRouterPeering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualRouterPeeringDelete.json
            // this example is just showing the usage of "VirtualRouterPeerings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterPeeringResource created on azure
            // for more information of creating VirtualRouterPeeringResource, please refer to the document of VirtualRouterPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            string peeringName = "peering1";
            ResourceIdentifier virtualRouterPeeringResourceId = VirtualRouterPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName, peeringName);
            VirtualRouterPeeringResource virtualRouterPeering = client.GetVirtualRouterPeeringResource(virtualRouterPeeringResourceId);

            // invoke the operation
            await virtualRouterPeering.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Virtual Router Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualRouterPeeringGet.json
            // this example is just showing the usage of "VirtualRouterPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterPeeringResource created on azure
            // for more information of creating VirtualRouterPeeringResource, please refer to the document of VirtualRouterPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            string peeringName = "peering1";
            ResourceIdentifier virtualRouterPeeringResourceId = VirtualRouterPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName, peeringName);
            VirtualRouterPeeringResource virtualRouterPeering = client.GetVirtualRouterPeeringResource(virtualRouterPeeringResourceId);

            // invoke the operation
            VirtualRouterPeeringResource result = await virtualRouterPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create Virtual Router Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VirtualRouterPeeringPut.json
            // this example is just showing the usage of "VirtualRouterPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterPeeringResource created on azure
            // for more information of creating VirtualRouterPeeringResource, please refer to the document of VirtualRouterPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            string peeringName = "peering1";
            ResourceIdentifier virtualRouterPeeringResourceId = VirtualRouterPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName, peeringName);
            VirtualRouterPeeringResource virtualRouterPeering = client.GetVirtualRouterPeeringResource(virtualRouterPeeringResourceId);

            // invoke the operation
            VirtualRouterPeeringData data = new VirtualRouterPeeringData()
            {
                PeerAsn = 20000,
                PeerIP = "192.168.1.5",
            };
            ArmOperation<VirtualRouterPeeringResource> lro = await virtualRouterPeering.UpdateAsync(WaitUntil.Completed, data);
            VirtualRouterPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
