// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_DenyAssignmentCollection
    {
        // Get deny assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDenyAssignmentByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetDenyAssignmentByNameId.json
            // this example is just showing the usage of "DenyAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DenyAssignmentResource
            string scope = "subscriptions/subId/resourcegroups/rgname";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            DenyAssignmentCollection collection = client.GetDenyAssignments(scopeId);

            // invoke the operation
            string denyAssignmentId = "denyAssignmentId";
            DenyAssignmentResource result = await collection.GetAsync(denyAssignmentId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DenyAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get deny assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDenyAssignmentByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetDenyAssignmentByNameId.json
            // this example is just showing the usage of "DenyAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DenyAssignmentResource
            string scope = "subscriptions/subId/resourcegroups/rgname";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            DenyAssignmentCollection collection = client.GetDenyAssignments(scopeId);

            // invoke the operation
            string denyAssignmentId = "denyAssignmentId";
            bool result = await collection.ExistsAsync(denyAssignmentId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get deny assignment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDenyAssignmentByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetDenyAssignmentByNameId.json
            // this example is just showing the usage of "DenyAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DenyAssignmentResource
            string scope = "subscriptions/subId/resourcegroups/rgname";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            DenyAssignmentCollection collection = client.GetDenyAssignments(scopeId);

            // invoke the operation
            string denyAssignmentId = "denyAssignmentId";
            NullableResponse<DenyAssignmentResource> response = await collection.GetIfExistsAsync(denyAssignmentId);
            DenyAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DenyAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List deny assignments for scope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDenyAssignmentsForScope()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetDenyAssignmentByScope.json
            // this example is just showing the usage of "DenyAssignments_ListForScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DenyAssignmentResource
            string scope = "subscriptions/subId";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            DenyAssignmentCollection collection = client.GetDenyAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (DenyAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DenyAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
