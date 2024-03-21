// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs.Samples
{
    public partial class Sample_NotificationHubNamespaceAuthorizationRuleResource
    {
        // NameSpaceAuthorizationRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NameSpaceAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleCreate.json
            // this example is just showing the usage of "Namespaces_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceAuthorizationRuleResource created on azure
            // for more information of creating NotificationHubNamespaceAuthorizationRuleResource, please refer to the document of NotificationHubNamespaceAuthorizationRuleResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier notificationHubNamespaceAuthorizationRuleResourceId = NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource notificationHubNamespaceAuthorizationRule = client.GetNotificationHubNamespaceAuthorizationRuleResource(notificationHubNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            SharedAccessAuthorizationRuleCreateOrUpdateContent content = new SharedAccessAuthorizationRuleCreateOrUpdateContent(new SharedAccessAuthorizationRuleProperties()
            {
                Rights =
{
AuthorizationRuleAccessRight.Listen,AuthorizationRuleAccessRight.Send
},
            });
            ArmOperation<NotificationHubNamespaceAuthorizationRuleResource> lro = await notificationHubNamespaceAuthorizationRule.UpdateAsync(WaitUntil.Completed, content);
            NotificationHubNamespaceAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NameSpaceAuthorizationRuleDelete()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleDelete.json
            // this example is just showing the usage of "Namespaces_DeleteAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceAuthorizationRuleResource created on azure
            // for more information of creating NotificationHubNamespaceAuthorizationRuleResource, please refer to the document of NotificationHubNamespaceAuthorizationRuleResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string authorizationRuleName = "RootManageSharedAccessKey";
            ResourceIdentifier notificationHubNamespaceAuthorizationRuleResourceId = NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource notificationHubNamespaceAuthorizationRule = client.GetNotificationHubNamespaceAuthorizationRuleResource(notificationHubNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            await notificationHubNamespaceAuthorizationRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "Namespaces_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceAuthorizationRuleResource created on azure
            // for more information of creating NotificationHubNamespaceAuthorizationRuleResource, please refer to the document of NotificationHubNamespaceAuthorizationRuleResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string authorizationRuleName = "RootManageSharedAccessKey";
            ResourceIdentifier notificationHubNamespaceAuthorizationRuleResourceId = NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource notificationHubNamespaceAuthorizationRule = client.GetNotificationHubNamespaceAuthorizationRuleResource(notificationHubNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            NotificationHubNamespaceAuthorizationRuleResource result = await notificationHubNamespaceAuthorizationRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleListKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_NameSpaceAuthorizationRuleListKey()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleListKey.json
            // this example is just showing the usage of "Namespaces_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceAuthorizationRuleResource created on azure
            // for more information of creating NotificationHubNamespaceAuthorizationRuleResource, please refer to the document of NotificationHubNamespaceAuthorizationRuleResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string authorizationRuleName = "RootManageSharedAccessKey";
            ResourceIdentifier notificationHubNamespaceAuthorizationRuleResourceId = NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource notificationHubNamespaceAuthorizationRule = client.GetNotificationHubNamespaceAuthorizationRuleResource(notificationHubNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            NotificationHubResourceKeys result = await notificationHubNamespaceAuthorizationRule.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameSpaceAuthorizationRuleRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_NameSpaceAuthorizationRuleRegenerateKey()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleRegenrateKey.json
            // this example is just showing the usage of "Namespaces_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceAuthorizationRuleResource created on azure
            // for more information of creating NotificationHubNamespaceAuthorizationRuleResource, please refer to the document of NotificationHubNamespaceAuthorizationRuleResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            string authorizationRuleName = "RootManageSharedAccessKey";
            ResourceIdentifier notificationHubNamespaceAuthorizationRuleResourceId = NotificationHubNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource notificationHubNamespaceAuthorizationRule = client.GetNotificationHubNamespaceAuthorizationRuleResource(notificationHubNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            NotificationHubPolicyKey notificationHubPolicyKey = new NotificationHubPolicyKey()
            {
                PolicyKey = "PrimaryKey",
            };
            NotificationHubResourceKeys result = await notificationHubNamespaceAuthorizationRule.RegenerateKeysAsync(notificationHubPolicyKey);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
