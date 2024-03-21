// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_TenantResourceHealthEventImpactedResource
    {
        // ImpactedResourcesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ImpactedResourcesGet()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/ImpactedResources_GetByTenantId.json
            // this example is just showing the usage of "ImpactedResources_GetByTenantId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResourceHealthEventImpactedResource created on azure
            // for more information of creating TenantResourceHealthEventImpactedResource, please refer to the document of TenantResourceHealthEventImpactedResource
            string eventTrackingId = "BC_1-FXZ";
            string impactedResourceName = "abc-123-ghj-456";
            ResourceIdentifier tenantResourceHealthEventImpactedResourceId = TenantResourceHealthEventImpactedResource.CreateResourceIdentifier(eventTrackingId, impactedResourceName);
            TenantResourceHealthEventImpactedResource tenantResourceHealthEventImpactedResource = client.GetTenantResourceHealthEventImpactedResource(tenantResourceHealthEventImpactedResourceId);

            // invoke the operation
            TenantResourceHealthEventImpactedResource result = await tenantResourceHealthEventImpactedResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthEventImpactedResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
