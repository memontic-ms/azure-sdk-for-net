// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_HybridComputeMachineResource
    {
        // Update a Machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAMachine()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machines_Update.json
            // this example is just showing the usage of "Machines_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            HybridComputeMachinePatch patch = new HybridComputeMachinePatch()
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                LocationData = new HybridComputeLocation("Redmond"),
                OSProfile = new HybridComputeOSProfile()
                {
                    WindowsConfiguration = new HybridComputeWindowsConfiguration()
                    {
                        AssessmentMode = AssessmentModeType.ImageDefault,
                        PatchMode = PatchModeType.Manual,
                    },
                    LinuxConfiguration = new HybridComputeLinuxConfiguration()
                    {
                        AssessmentMode = AssessmentModeType.ImageDefault,
                        PatchMode = PatchModeType.Manual,
                    },
                },
                ParentClusterResourceId = new ResourceIdentifier("{AzureStackHCIResourceId}"),
                PrivateLinkScopeResourceId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.HybridCompute/privateLinkScopes/privateLinkScopeName"),
            };
            HybridComputeMachineResource result = await hybridComputeMachine.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a Machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAMachine()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machines_Delete.json
            // this example is just showing the usage of "Machines_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            await hybridComputeMachine.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMachine()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machines_Get.json
            // this example is just showing the usage of "Machines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            HybridComputeMachineResource result = await hybridComputeMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Machine with License Profile Instance View
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMachineWithLicenseProfileInstanceView()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machines_Get_LicenseProfileInstanceView.json
            // this example is just showing the usage of "Machines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            string expand = "instanceView";
            HybridComputeMachineResource result = await hybridComputeMachine.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Assess patch state of a machine.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task AssessPatches_AssessPatchStateOfAMachine()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machine_AssessPatches.json
            // this example is just showing the usage of "Machines_AssessPatches" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroupName";
            string name = "myMachineName";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            ArmOperation<MachineAssessPatchesResult> lro = await hybridComputeMachine.AssessPatchesAsync(WaitUntil.Completed);
            MachineAssessPatchesResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Install patch state of a machine.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task InstallPatches_InstallPatchStateOfAMachine()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machine_InstallPatches.json
            // this example is just showing the usage of "Machines_InstallPatches" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroupName";
            string name = "myMachineName";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            MachineInstallPatchesContent content = new MachineInstallPatchesContent(XmlConvert.ToTimeSpan("PT4H"), VmGuestPatchRebootSetting.IfRequired)
            {
                WindowsParameters = new HybridComputeWindowsParameters()
                {
                    ClassificationsToInclude =
{
VmGuestPatchClassificationWindow.Critical,VmGuestPatchClassificationWindow.Security
},
                    MaxPatchPublishOn = DateTimeOffset.Parse("2021-08-19T02:36:43.0539904+00:00"),
                },
            };
            ArmOperation<MachineInstallPatchesResult> lro = await hybridComputeMachine.InstallPatchesAsync(WaitUntil.Completed, content);
            MachineInstallPatchesResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Machines by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetHybridComputeMachines_ListMachinesByResourceGroup()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/machine/Machines_ListBySubscription.json
            // this example is just showing the usage of "Machines_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (HybridComputeMachineResource item in subscriptionResource.GetHybridComputeMachinesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridComputeMachineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Upgrade Machine Extensions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpgradeExtensions_UpgradeMachineExtensions()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extensions_Upgrade.json
            // this example is just showing the usage of "UpgradeExtensions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            MachineExtensionUpgrade extensionUpgradeParameters = new MachineExtensionUpgrade()
            {
                ExtensionTargets =
{
["Microsoft.Azure.Monitoring"] = new ExtensionTargetProperties()
{
TargetVersion = "2.0",
},
["Microsoft.Compute.CustomScriptExtension"] = new ExtensionTargetProperties()
{
TargetVersion = "1.10",
},
},
            };
            await hybridComputeMachine.UpgradeExtensionsAsync(WaitUntil.Completed, extensionUpgradeParameters);

            Console.WriteLine($"Succeeded");
        }

        // GET Network Profile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkProfile_GETNetworkProfile()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/NetworkProfile_Get.json
            // this example is just showing the usage of "NetworkProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            HybridComputeNetworkProfile result = await hybridComputeMachine.GetNetworkProfileAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateLinkScopeGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetValidationDetailsForMachinePrivateLinkScope_PrivateLinkScopeGet()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/privateLinkScope/PrivateLinkScopes_GetValidationForMachine.json
            // this example is just showing the usage of "PrivateLinkScopes_GetValidationDetailsForMachine" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            string machineName = "machineName";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // invoke the operation
            PrivateLinkScopeValidationDetails result = await hybridComputeMachine.GetValidationDetailsForMachinePrivateLinkScopeAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
