// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Qumulo.Samples
{
    public partial class Sample_QumuloFileSystemResourceCollection
    {
        // FileSystems_ListByResourceGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FileSystemsListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation and iterate over the result
            await foreach (QumuloFileSystemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FileSystems_ListByResourceGroup_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FileSystemsListByResourceGroupMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation and iterate over the result
            await foreach (QumuloFileSystemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FileSystems_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FileSystemsGetMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            QumuloFileSystemResource result = await collection.GetAsync(fileSystemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FileSystemsGetMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            bool result = await collection.ExistsAsync(fileSystemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FileSystems_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FileSystemsGetMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            NullableResponse<QumuloFileSystemResource> response = await collection.GetIfExistsAsync(fileSystemName);
            QumuloFileSystemResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FileSystems_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FileSystemsGetMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            QumuloFileSystemResource result = await collection.GetAsync(fileSystemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FileSystemsGetMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            bool result = await collection.ExistsAsync(fileSystemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FileSystems_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FileSystemsGetMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            NullableResponse<QumuloFileSystemResource> response = await collection.GetIfExistsAsync(fileSystemName);
            QumuloFileSystemResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FileSystems_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FileSystemsCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            QumuloFileSystemResourceData data = new QumuloFileSystemResourceData(new AzureLocation("przdlsmlzsszphnixq"), new MarketplaceDetails("x", "eiyhbmpwgezcmzrrfoiskuxlcvwojf", "wfmokfdjbwpjhz")
            {
                MarketplaceSubscriptionId = "ujrcqvxfnhxxheoth",
            }, StorageSku.Standard, new QumuloUserDetails()
            {
                Email = "viptslwulnpaupfljvnjeq",
            }, "neqctctqdmjezfgt", "ekceujoecaashtjlsgcymnrdozk", 9)
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key4522")] = new UserAssignedIdentity(),
},
                },
                ClusterLoginUri = new Uri("jjqhgevy"),
                PrivateIPs =
{
IPAddress.Parse("kslguxrwbwkrj")
},
                AvailabilityZone = "maseyqhlnhoiwbabcqabtedbjpip",
                Tags =
{
["key6565"] = "cgdhmupta",
},
            };
            ArmOperation<QumuloFileSystemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fileSystemName, data);
            QumuloFileSystemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FileSystemsCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "aaaaaaaaaaaaaaaaaaaaaaaa";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this QumuloFileSystemResource
            QumuloFileSystemResourceCollection collection = resourceGroupResource.GetQumuloFileSystemResources();

            // invoke the operation
            string fileSystemName = "aaaaaaaa";
            QumuloFileSystemResourceData data = new QumuloFileSystemResourceData(new AzureLocation("aaaaaaaaaaaaaaaaaaaaaaaaa"), new MarketplaceDetails("aaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaa", "aa")
            {
                MarketplaceSubscriptionId = "aaaaaaaaaaaaa",
            }, StorageSku.Standard, new QumuloUserDetails()
            {
                Email = "viptslwulnpaupfljvnjeq",
            }, "aaaaaaaaaa", "ekceujoecaashtjlsgcymnrdozk", 9);
            ArmOperation<QumuloFileSystemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fileSystemName, data);
            QumuloFileSystemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
