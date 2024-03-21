// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_StorageAccountLocalUserCollection
    {
        // ListLocalUsers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListLocalUsers()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUsersList.json
            // this example is just showing the usage of "LocalUsers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation and iterate over the result
            await foreach (StorageAccountLocalUserResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageAccountLocalUserData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetLocalUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLocalUser()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUserGet.json
            // this example is just showing the usage of "LocalUsers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation
            string username = "user1";
            StorageAccountLocalUserResource result = await collection.GetAsync(username);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountLocalUserData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetLocalUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetLocalUser()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUserGet.json
            // this example is just showing the usage of "LocalUsers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation
            string username = "user1";
            bool result = await collection.ExistsAsync(username);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetLocalUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetLocalUser()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUserGet.json
            // this example is just showing the usage of "LocalUsers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation
            string username = "user1";
            NullableResponse<StorageAccountLocalUserResource> response = await collection.GetIfExistsAsync(username);
            StorageAccountLocalUserResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageAccountLocalUserData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateLocalUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateLocalUser()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUserCreate.json
            // this example is just showing the usage of "LocalUsers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation
            string username = "user1";
            StorageAccountLocalUserData data = new StorageAccountLocalUserData()
            {
                PermissionScopes =
{
new StoragePermissionScope("rwd","file","share1"),new StoragePermissionScope("rw","file","share2")
},
                HomeDirectory = "homedirectory",
                SshAuthorizedKeys =
{
new StorageSshPublicKey()
{
Description = "key name",
Key = "ssh-rsa keykeykeykeykey=",
}
},
                HasSshPassword = true,
            };
            ArmOperation<StorageAccountLocalUserResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, username, data);
            StorageAccountLocalUserResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountLocalUserData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateLocalUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateLocalUser()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/LocalUserUpdate.json
            // this example is just showing the usage of "LocalUsers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StorageAccountLocalUserResource
            StorageAccountLocalUserCollection collection = storageAccount.GetStorageAccountLocalUsers();

            // invoke the operation
            string username = "user1";
            StorageAccountLocalUserData data = new StorageAccountLocalUserData()
            {
                HomeDirectory = "homedirectory2",
                HasSharedKey = false,
                HasSshKey = false,
                HasSshPassword = false,
            };
            ArmOperation<StorageAccountLocalUserResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, username, data);
            StorageAccountLocalUserResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountLocalUserData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
