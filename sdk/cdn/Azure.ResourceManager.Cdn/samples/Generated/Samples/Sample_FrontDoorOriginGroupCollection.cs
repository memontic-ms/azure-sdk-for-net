// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorOriginGroupCollection
    {
        // AFDOriginGroups_ListByProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AFDOriginGroupsListByProfile()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDOriginGroups_ListByProfile.json
            // this example is just showing the usage of "FrontDoorOriginGroups_ListByProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorOriginGroupResource
            FrontDoorOriginGroupCollection collection = profile.GetFrontDoorOriginGroups();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorOriginGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorOriginGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AFDOriginGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AFDOriginGroupsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDOriginGroups_Get.json
            // this example is just showing the usage of "FrontDoorOriginGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorOriginGroupResource
            FrontDoorOriginGroupCollection collection = profile.GetFrontDoorOriginGroups();

            // invoke the operation
            string originGroupName = "origingroup1";
            FrontDoorOriginGroupResource result = await collection.GetAsync(originGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorOriginGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AFDOriginGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AFDOriginGroupsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDOriginGroups_Get.json
            // this example is just showing the usage of "FrontDoorOriginGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorOriginGroupResource
            FrontDoorOriginGroupCollection collection = profile.GetFrontDoorOriginGroups();

            // invoke the operation
            string originGroupName = "origingroup1";
            bool result = await collection.ExistsAsync(originGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AFDOriginGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AFDOriginGroupsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDOriginGroups_Get.json
            // this example is just showing the usage of "FrontDoorOriginGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorOriginGroupResource
            FrontDoorOriginGroupCollection collection = profile.GetFrontDoorOriginGroups();

            // invoke the operation
            string originGroupName = "origingroup1";
            NullableResponse<FrontDoorOriginGroupResource> response = await collection.GetIfExistsAsync(originGroupName);
            FrontDoorOriginGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorOriginGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // AFDOriginGroups_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AFDOriginGroupsCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/AFDOriginGroups_Create.json
            // this example is just showing the usage of "FrontDoorOriginGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorOriginGroupResource
            FrontDoorOriginGroupCollection collection = profile.GetFrontDoorOriginGroups();

            // invoke the operation
            string originGroupName = "origingroup1";
            FrontDoorOriginGroupData data = new FrontDoorOriginGroupData()
            {
                LoadBalancingSettings = new LoadBalancingSettings()
                {
                    SampleSize = 3,
                    SuccessfulSamplesRequired = 3,
                    AdditionalLatencyInMilliseconds = 1000,
                },
                HealthProbeSettings = new HealthProbeSettings()
                {
                    ProbePath = "/path2",
                    ProbeRequestType = HealthProbeRequestType.NotSet,
                    ProbeProtocol = HealthProbeProtocol.NotSet,
                    ProbeIntervalInSeconds = 10,
                },
                TrafficRestorationTimeInMinutes = 5,
            };
            ArmOperation<FrontDoorOriginGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, originGroupName, data);
            FrontDoorOriginGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorOriginGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
