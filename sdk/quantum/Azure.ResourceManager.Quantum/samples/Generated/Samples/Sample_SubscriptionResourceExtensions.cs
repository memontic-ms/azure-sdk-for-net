// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Quantum.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Quantum.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // OfferingsList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetOfferings_OfferingsList()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/offeringsList.json
            // this example is just showing the usage of "Offerings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1C4B2828-7D49-494F-933D-061373BE28C2";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            string locationName = "westus2";
            await foreach (QuantumProviderDescription item in subscriptionResource.GetOfferingsAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // QuantumWorkspacesCheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckWorkspaceNameAvailability_QuantumWorkspacesCheckNameAvailability()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/quantumWorkspacesCheckNameAvailability.json
            // this example is just showing the usage of "Workspace_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string locationName = "westus2";
            WorkspaceNameAvailabilityContent content = new WorkspaceNameAvailabilityContent()
            {
                Name = "sample-workspace-name",
                ResourceType = new ResourceType("Microsoft.Quantum/Workspaces"),
            };
            WorkspaceNameAvailabilityResult result = await subscriptionResource.CheckWorkspaceNameAvailabilityAsync(locationName, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
