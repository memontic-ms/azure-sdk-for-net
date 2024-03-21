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
    public partial class Sample_MachineLearningEnvironmentContainerResource
    {
        // Delete Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/delete.json
            // this example is just showing the usage of "EnvironmentContainers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningEnvironmentContainerResource, please refer to the document of MachineLearningEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            string name = "testContainer";
            ResourceIdentifier machineLearningEnvironmentContainerResourceId = MachineLearningEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningEnvironmentContainerResource machineLearningEnvironmentContainer = client.GetMachineLearningEnvironmentContainerResource(machineLearningEnvironmentContainerResourceId);

            // invoke the operation
            await machineLearningEnvironmentContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/get.json
            // this example is just showing the usage of "EnvironmentContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningEnvironmentContainerResource, please refer to the document of MachineLearningEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            string name = "testEnvironment";
            ResourceIdentifier machineLearningEnvironmentContainerResourceId = MachineLearningEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningEnvironmentContainerResource machineLearningEnvironmentContainer = client.GetMachineLearningEnvironmentContainerResource(machineLearningEnvironmentContainerResourceId);

            // invoke the operation
            MachineLearningEnvironmentContainerResource result = await machineLearningEnvironmentContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Environment Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceEnvironmentContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/EnvironmentContainer/createOrUpdate.json
            // this example is just showing the usage of "EnvironmentContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentContainerResource created on azure
            // for more information of creating MachineLearningEnvironmentContainerResource, please refer to the document of MachineLearningEnvironmentContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "testworkspace";
            string name = "testEnvironment";
            ResourceIdentifier machineLearningEnvironmentContainerResourceId = MachineLearningEnvironmentContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningEnvironmentContainerResource machineLearningEnvironmentContainer = client.GetMachineLearningEnvironmentContainerResource(machineLearningEnvironmentContainerResourceId);

            // invoke the operation
            MachineLearningEnvironmentContainerData data = new MachineLearningEnvironmentContainerData(new MachineLearningEnvironmentContainerProperties()
            {
                Description = "string",
                Properties =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
            });
            ArmOperation<MachineLearningEnvironmentContainerResource> lro = await machineLearningEnvironmentContainer.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningEnvironmentContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
