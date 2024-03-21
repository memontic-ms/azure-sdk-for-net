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
    public partial class Sample_ApiTagResource
    {
        // ApiManagementHeadApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityStateByApi_ApiManagementHeadApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementHeadApiTag.json
            // this example is just showing the usage of "Tag_GetEntityStateByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagResource created on azure
            // for more information of creating ApiTagResource, please refer to the document of ApiTagResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiTagResourceId = ApiTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagId);
            ApiTagResource apiTag = client.GetApiTagResource(apiTagResourceId);

            // invoke the operation
            bool result = await apiTag.GetEntityStateByApiAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiTag.json
            // this example is just showing the usage of "Tag_GetByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagResource created on azure
            // for more information of creating ApiTagResource, please refer to the document of ApiTagResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiTagResourceId = ApiTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagId);
            ApiTagResource apiTag = client.GetApiTagResource(apiTagResourceId);

            // invoke the operation
            ApiTagResource result = await apiTag.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateApiTag.json
            // this example is just showing the usage of "Tag_AssignToApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagResource created on azure
            // for more information of creating ApiTagResource, please refer to the document of ApiTagResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5931a75ae4bbd512a88c680b";
            string tagId = "tagId1";
            ResourceIdentifier apiTagResourceId = ApiTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagId);
            ApiTagResource apiTag = client.GetApiTagResource(apiTagResourceId);

            // invoke the operation
            ArmOperation<ApiTagResource> lro = await apiTag.UpdateAsync(WaitUntil.Completed);
            ApiTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementDeleteApiTag.json
            // this example is just showing the usage of "Tag_DetachFromApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagResource created on azure
            // for more information of creating ApiTagResource, please refer to the document of ApiTagResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d5b28d1f7fab116c282650";
            string tagId = "59d5b28e1f7fab116402044e";
            ResourceIdentifier apiTagResourceId = ApiTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagId);
            ApiTagResource apiTag = client.GetApiTagResource(apiTagResourceId);

            // invoke the operation
            await apiTag.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
