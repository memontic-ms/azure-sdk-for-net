// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningRegistryDataContainerResource
    {
        // Delete Registry Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRegistryDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataContainer/delete.json
            // this example is just showing the usage of "RegistryDataContainers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataContainerResource created on azure
            // for more information of creating MachineLearningRegistryDataContainerResource, please refer to the document of MachineLearningRegistryDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            ResourceIdentifier machineLearningRegistryDataContainerResourceId = MachineLearningRegistryDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name);
            MachineLearningRegistryDataContainerResource machineLearningRegistryDataContainer = client.GetMachineLearningRegistryDataContainerResource(machineLearningRegistryDataContainerResourceId);

            // invoke the operation
            await machineLearningRegistryDataContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataContainer/get.json
            // this example is just showing the usage of "RegistryDataContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataContainerResource created on azure
            // for more information of creating MachineLearningRegistryDataContainerResource, please refer to the document of MachineLearningRegistryDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            ResourceIdentifier machineLearningRegistryDataContainerResourceId = MachineLearningRegistryDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name);
            MachineLearningRegistryDataContainerResource machineLearningRegistryDataContainer = client.GetMachineLearningRegistryDataContainerResource(machineLearningRegistryDataContainerResourceId);

            // invoke the operation
            MachineLearningRegistryDataContainerResource result = await machineLearningRegistryDataContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Registry Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateRegistryDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataContainer/createOrUpdate.json
            // this example is just showing the usage of "RegistryDataContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataContainerResource created on azure
            // for more information of creating MachineLearningRegistryDataContainerResource, please refer to the document of MachineLearningRegistryDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            ResourceIdentifier machineLearningRegistryDataContainerResourceId = MachineLearningRegistryDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name);
            MachineLearningRegistryDataContainerResource machineLearningRegistryDataContainer = client.GetMachineLearningRegistryDataContainerResource(machineLearningRegistryDataContainerResourceId);

            // invoke the operation
            MachineLearningDataContainerData data = new MachineLearningDataContainerData(new MachineLearningDataContainerProperties(MachineLearningDataType.UriFolder)
            {
                IsArchived = false,
                Description = "string",
                Properties =
{
["string"] = "string",
},
                Tags =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningRegistryDataContainerResource> lro = await machineLearningRegistryDataContainer.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningRegistryDataContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
