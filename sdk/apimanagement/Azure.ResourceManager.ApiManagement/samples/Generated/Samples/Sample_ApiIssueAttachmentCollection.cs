// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiIssueAttachmentCollection
    {
        // ApiManagementListApiIssueAttachments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListApiIssueAttachments()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListApiIssueAttachments.json
            // this example is just showing the usage of "ApiIssueAttachment_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueAttachmentResource
            ApiIssueAttachmentCollection collection = apiIssue.GetApiIssueAttachments();

            // invoke the operation and iterate over the result
            await foreach (ApiIssueAttachmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiIssueAttachmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetApiIssueAttachment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueAttachmentResource
            ApiIssueAttachmentCollection collection = apiIssue.GetApiIssueAttachments();

            // invoke the operation
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ApiIssueAttachmentResource result = await collection.GetAsync(attachmentId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueAttachmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetApiIssueAttachment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueAttachmentResource
            ApiIssueAttachmentCollection collection = apiIssue.GetApiIssueAttachments();

            // invoke the operation
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            bool result = await collection.ExistsAsync(attachmentId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiIssueAttachment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueAttachmentResource
            ApiIssueAttachmentCollection collection = apiIssue.GetApiIssueAttachments();

            // invoke the operation
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            NullableResponse<ApiIssueAttachmentResource> response = await collection.GetIfExistsAsync(attachmentId);
            ApiIssueAttachmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiIssueAttachmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateApiIssueAttachment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueAttachmentResource
            ApiIssueAttachmentCollection collection = apiIssue.GetApiIssueAttachments();

            // invoke the operation
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ApiIssueAttachmentData data = new ApiIssueAttachmentData()
            {
                Title = "Issue attachment.",
                ContentFormat = "image/jpeg",
                Content = "IEJhc2U2NA==",
            };
            ArmOperation<ApiIssueAttachmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, attachmentId, data);
            ApiIssueAttachmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueAttachmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
