// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusQueueCollection
    {
        // QueueListByNameSpace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_QueueListByNameSpace()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Queues/SBQueueListByNameSpace.json
            // this example is just showing the usage of "Queues_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusQueueResource
            ServiceBusQueueCollection collection = serviceBusNamespace.GetServiceBusQueues();

            // invoke the operation and iterate over the result
            await foreach (ServiceBusQueueResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusQueueData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // QueueCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_QueueCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Queues/SBQueueCreate.json
            // this example is just showing the usage of "Queues_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusQueueResource
            ServiceBusQueueCollection collection = serviceBusNamespace.GetServiceBusQueues();

            // invoke the operation
            string queueName = "sdk-Queues-5647";
            ServiceBusQueueData data = new ServiceBusQueueData()
            {
                EnablePartitioning = true,
            };
            ArmOperation<ServiceBusQueueResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, queueName, data);
            ServiceBusQueueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusQueueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // QueueGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_QueueGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Queues/SBQueueGet.json
            // this example is just showing the usage of "Queues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusQueueResource
            ServiceBusQueueCollection collection = serviceBusNamespace.GetServiceBusQueues();

            // invoke the operation
            string queueName = "sdk-Queues-5647";
            ServiceBusQueueResource result = await collection.GetAsync(queueName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusQueueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // QueueGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_QueueGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Queues/SBQueueGet.json
            // this example is just showing the usage of "Queues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusQueueResource
            ServiceBusQueueCollection collection = serviceBusNamespace.GetServiceBusQueues();

            // invoke the operation
            string queueName = "sdk-Queues-5647";
            bool result = await collection.ExistsAsync(queueName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // QueueGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_QueueGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Queues/SBQueueGet.json
            // this example is just showing the usage of "Queues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusQueueResource
            ServiceBusQueueCollection collection = serviceBusNamespace.GetServiceBusQueues();

            // invoke the operation
            string queueName = "sdk-Queues-5647";
            NullableResponse<ServiceBusQueueResource> response = await collection.GetIfExistsAsync(queueName);
            ServiceBusQueueResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusQueueData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
