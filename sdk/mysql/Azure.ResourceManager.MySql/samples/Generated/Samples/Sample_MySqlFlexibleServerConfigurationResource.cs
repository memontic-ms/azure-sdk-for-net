// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerConfigurationResource
    {
        // Update a user configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAUserConfiguration()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/preview/2023-06-01-preview/examples/ConfigurationUpdate.json
            // this example is just showing the usage of "Configurations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerConfigurationResource created on azure
            // for more information of creating MySqlFlexibleServerConfigurationResource, please refer to the document of MySqlFlexibleServerConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string configurationName = "event_scheduler";
            ResourceIdentifier mySqlFlexibleServerConfigurationResourceId = MySqlFlexibleServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, configurationName);
            MySqlFlexibleServerConfigurationResource mySqlFlexibleServerConfiguration = client.GetMySqlFlexibleServerConfigurationResource(mySqlFlexibleServerConfigurationResourceId);

            // invoke the operation
            MySqlFlexibleServerConfigurationData data = new MySqlFlexibleServerConfigurationData()
            {
                Value = "on",
                Source = MySqlFlexibleServerConfigurationSource.UserOverride,
            };
            ArmOperation<MySqlFlexibleServerConfigurationResource> lro = await mySqlFlexibleServerConfiguration.UpdateAsync(WaitUntil.Completed, data);
            MySqlFlexibleServerConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAConfiguration()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/preview/2023-06-01-preview/examples/ConfigurationGet.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerConfigurationResource created on azure
            // for more information of creating MySqlFlexibleServerConfigurationResource, please refer to the document of MySqlFlexibleServerConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string configurationName = "event_scheduler";
            ResourceIdentifier mySqlFlexibleServerConfigurationResourceId = MySqlFlexibleServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, configurationName);
            MySqlFlexibleServerConfigurationResource mySqlFlexibleServerConfiguration = client.GetMySqlFlexibleServerConfigurationResource(mySqlFlexibleServerConfigurationResourceId);

            // invoke the operation
            MySqlFlexibleServerConfigurationResource result = await mySqlFlexibleServerConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
