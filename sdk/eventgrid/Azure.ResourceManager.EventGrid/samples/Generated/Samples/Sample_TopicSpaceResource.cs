// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_TopicSpaceResource
    {
        // TopicSpaces_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TopicSpacesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/TopicSpaces_Get.json
            // this example is just showing the usage of "TopicSpaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicSpaceResource created on azure
            // for more information of creating TopicSpaceResource, please refer to the document of TopicSpaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicSpaceName = "exampleTopicSpaceName1";
            ResourceIdentifier topicSpaceResourceId = TopicSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicSpaceName);
            TopicSpaceResource topicSpace = client.GetTopicSpaceResource(topicSpaceResourceId);

            // invoke the operation
            TopicSpaceResource result = await topicSpace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TopicSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TopicSpaces_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TopicSpacesCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/TopicSpaces_CreateOrUpdate.json
            // this example is just showing the usage of "TopicSpaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicSpaceResource created on azure
            // for more information of creating TopicSpaceResource, please refer to the document of TopicSpaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicSpaceName = "exampleTopicSpaceName1";
            ResourceIdentifier topicSpaceResourceId = TopicSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicSpaceName);
            TopicSpaceResource topicSpace = client.GetTopicSpaceResource(topicSpaceResourceId);

            // invoke the operation
            TopicSpaceData data = new TopicSpaceData()
            {
                TopicTemplates =
{
"filter1","filter2"
},
            };
            ArmOperation<TopicSpaceResource> lro = await topicSpace.UpdateAsync(WaitUntil.Completed, data);
            TopicSpaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TopicSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TopicSpaces_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TopicSpacesDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/TopicSpaces_Delete.json
            // this example is just showing the usage of "TopicSpaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicSpaceResource created on azure
            // for more information of creating TopicSpaceResource, please refer to the document of TopicSpaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicSpaceName = "exampleTopicSpaceName1";
            ResourceIdentifier topicSpaceResourceId = TopicSpaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicSpaceName);
            TopicSpaceResource topicSpace = client.GetTopicSpaceResource(topicSpaceResourceId);

            // invoke the operation
            await topicSpace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
