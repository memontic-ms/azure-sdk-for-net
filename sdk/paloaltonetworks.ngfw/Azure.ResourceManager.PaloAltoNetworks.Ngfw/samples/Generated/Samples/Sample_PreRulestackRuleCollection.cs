// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_PreRulestackRuleCollection
    {
        // PreRules_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PreRulesListMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_List_MaximumSet_Gen.json
            // this example is just showing the usage of "PreRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation and iterate over the result
            await foreach (PreRulestackRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PreRulestackRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PreRules_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PreRulesListMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_List_MinimumSet_Gen.json
            // this example is just showing the usage of "PreRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation and iterate over the result
            await foreach (PreRulestackRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PreRulestackRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PreRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PreRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            PreRulestackRuleResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PreRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PreRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PreRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PreRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PreRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            NullableResponse<PreRulestackRuleResource> response = await collection.GetIfExistsAsync(priority);
            PreRulestackRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PreRulestackRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PreRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PreRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            PreRulestackRuleResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PreRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PreRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PreRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PreRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PreRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PreRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            NullableResponse<PreRulestackRuleResource> response = await collection.GetIfExistsAsync(priority);
            PreRulestackRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PreRulestackRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PreRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PreRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "PreRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            PreRulestackRuleData data = new PreRulestackRuleData("preRule1")
            {
                ETag = new ETag("c18e6eef-ba3e-49ee-8a85-2b36c863a9d0"),
                Description = "description of pre rule",
                RuleState = RulestackStateType.Disabled,
                Source = new SourceAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                },
                NegateSource = FirewallBooleanType.True,
                Destination = new DestinationAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                    FqdnLists =
{
"FQDN1"
},
                },
                NegateDestination = FirewallBooleanType.True,
                Applications =
{
"app1"
},
                Category = new EdlMatchCategory(new string[]
            {
"https://microsoft.com"
            }, new string[]
            {
"feed"
            }),
                Protocol = "HTTP",
                ProtocolPortList =
{
"80"
},
                InboundInspectionCertificate = "cert1",
                AuditComment = "example comment",
                ActionType = RulestackActionType.Allow,
                EnableLogging = RulestackStateType.Disabled,
                DecryptionRuleType = DecryptionRuleType.SslOutboundInspection,
                Tags =
{
new RulestackTagInfo("keyName","value")
},
            };
            ArmOperation<PreRulestackRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            PreRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PreRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PreRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PreRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PreRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "PreRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PreRulestackRuleResource
            PreRulestackRuleCollection collection = globalRulestack.GetPreRulestackRules();

            // invoke the operation
            string priority = "1";
            PreRulestackRuleData data = new PreRulestackRuleData("preRule1");
            ArmOperation<PreRulestackRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            PreRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PreRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
