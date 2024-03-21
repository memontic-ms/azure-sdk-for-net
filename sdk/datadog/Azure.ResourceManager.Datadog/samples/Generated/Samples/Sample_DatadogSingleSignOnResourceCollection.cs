// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Datadog.Samples
{
    public partial class Sample_DatadogSingleSignOnResourceCollection
    {
        // SingleSignOnConfigurations_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SingleSignOnConfigurationsList()
        {
            // Generated from example definition: specification/datadog/resource-manager/Microsoft.Datadog/stable/2021-03-01/examples/SingleSignOnConfigurations_List.json
            // this example is just showing the usage of "SingleSignOnConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatadogMonitorResource created on azure
            // for more information of creating DatadogMonitorResource, please refer to the document of DatadogMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier datadogMonitorResourceId = DatadogMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            DatadogMonitorResource datadogMonitorResource = client.GetDatadogMonitorResource(datadogMonitorResourceId);

            // get the collection of this DatadogSingleSignOnResource
            DatadogSingleSignOnResourceCollection collection = datadogMonitorResource.GetDatadogSingleSignOnResources();

            // invoke the operation and iterate over the result
            await foreach (DatadogSingleSignOnResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DatadogSingleSignOnResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SingleSignOnConfigurations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SingleSignOnConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/datadog/resource-manager/Microsoft.Datadog/stable/2021-03-01/examples/SingleSignOnConfigurations_CreateOrUpdate.json
            // this example is just showing the usage of "SingleSignOnConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatadogMonitorResource created on azure
            // for more information of creating DatadogMonitorResource, please refer to the document of DatadogMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier datadogMonitorResourceId = DatadogMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            DatadogMonitorResource datadogMonitorResource = client.GetDatadogMonitorResource(datadogMonitorResourceId);

            // get the collection of this DatadogSingleSignOnResource
            DatadogSingleSignOnResourceCollection collection = datadogMonitorResource.GetDatadogSingleSignOnResources();

            // invoke the operation
            string configurationName = "default";
            DatadogSingleSignOnResourceData data = new DatadogSingleSignOnResourceData();
            ArmOperation<DatadogSingleSignOnResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationName, data);
            DatadogSingleSignOnResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatadogSingleSignOnResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SingleSignOnConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SingleSignOnConfigurationsGet()
        {
            // Generated from example definition: specification/datadog/resource-manager/Microsoft.Datadog/stable/2021-03-01/examples/SingleSignOnConfigurations_Get.json
            // this example is just showing the usage of "SingleSignOnConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatadogMonitorResource created on azure
            // for more information of creating DatadogMonitorResource, please refer to the document of DatadogMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier datadogMonitorResourceId = DatadogMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            DatadogMonitorResource datadogMonitorResource = client.GetDatadogMonitorResource(datadogMonitorResourceId);

            // get the collection of this DatadogSingleSignOnResource
            DatadogSingleSignOnResourceCollection collection = datadogMonitorResource.GetDatadogSingleSignOnResources();

            // invoke the operation
            string configurationName = "default";
            DatadogSingleSignOnResource result = await collection.GetAsync(configurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatadogSingleSignOnResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SingleSignOnConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SingleSignOnConfigurationsGet()
        {
            // Generated from example definition: specification/datadog/resource-manager/Microsoft.Datadog/stable/2021-03-01/examples/SingleSignOnConfigurations_Get.json
            // this example is just showing the usage of "SingleSignOnConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatadogMonitorResource created on azure
            // for more information of creating DatadogMonitorResource, please refer to the document of DatadogMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier datadogMonitorResourceId = DatadogMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            DatadogMonitorResource datadogMonitorResource = client.GetDatadogMonitorResource(datadogMonitorResourceId);

            // get the collection of this DatadogSingleSignOnResource
            DatadogSingleSignOnResourceCollection collection = datadogMonitorResource.GetDatadogSingleSignOnResources();

            // invoke the operation
            string configurationName = "default";
            bool result = await collection.ExistsAsync(configurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SingleSignOnConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SingleSignOnConfigurationsGet()
        {
            // Generated from example definition: specification/datadog/resource-manager/Microsoft.Datadog/stable/2021-03-01/examples/SingleSignOnConfigurations_Get.json
            // this example is just showing the usage of "SingleSignOnConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatadogMonitorResource created on azure
            // for more information of creating DatadogMonitorResource, please refer to the document of DatadogMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier datadogMonitorResourceId = DatadogMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            DatadogMonitorResource datadogMonitorResource = client.GetDatadogMonitorResource(datadogMonitorResourceId);

            // get the collection of this DatadogSingleSignOnResource
            DatadogSingleSignOnResourceCollection collection = datadogMonitorResource.GetDatadogSingleSignOnResources();

            // invoke the operation
            string configurationName = "default";
            NullableResponse<DatadogSingleSignOnResource> response = await collection.GetIfExistsAsync(configurationName);
            DatadogSingleSignOnResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DatadogSingleSignOnResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
