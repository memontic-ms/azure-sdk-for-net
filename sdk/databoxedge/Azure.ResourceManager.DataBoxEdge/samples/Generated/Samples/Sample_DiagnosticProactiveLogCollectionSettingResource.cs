// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_DiagnosticProactiveLogCollectionSettingResource
    {
        // GetDiagnosticProactiveLogCollectionSettings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDiagnosticProactiveLogCollectionSettings()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/GetDiagnosticProactiveLogCollectionSettings.json
            // this example is just showing the usage of "DiagnosticSettings_GetDiagnosticProactiveLogCollectionSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticProactiveLogCollectionSettingResource created on azure
            // for more information of creating DiagnosticProactiveLogCollectionSettingResource, please refer to the document of DiagnosticProactiveLogCollectionSettingResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier diagnosticProactiveLogCollectionSettingResourceId = DiagnosticProactiveLogCollectionSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DiagnosticProactiveLogCollectionSettingResource diagnosticProactiveLogCollectionSetting = client.GetDiagnosticProactiveLogCollectionSettingResource(diagnosticProactiveLogCollectionSettingResourceId);

            // invoke the operation
            DiagnosticProactiveLogCollectionSettingResource result = await diagnosticProactiveLogCollectionSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticProactiveLogCollectionSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateDiagnosticProactiveLogCollectionSettings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateDiagnosticProactiveLogCollectionSettings()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/UpdateDiagnosticProactiveLogCollectionSettings.json
            // this example is just showing the usage of "DiagnosticSettings_UpdateDiagnosticProactiveLogCollectionSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticProactiveLogCollectionSettingResource created on azure
            // for more information of creating DiagnosticProactiveLogCollectionSettingResource, please refer to the document of DiagnosticProactiveLogCollectionSettingResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier diagnosticProactiveLogCollectionSettingResourceId = DiagnosticProactiveLogCollectionSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DiagnosticProactiveLogCollectionSettingResource diagnosticProactiveLogCollectionSetting = client.GetDiagnosticProactiveLogCollectionSettingResource(diagnosticProactiveLogCollectionSettingResourceId);

            // invoke the operation
            DiagnosticProactiveLogCollectionSettingData data = new DiagnosticProactiveLogCollectionSettingData(ProactiveDiagnosticsConsent.Enabled);
            ArmOperation<DiagnosticProactiveLogCollectionSettingResource> lro = await diagnosticProactiveLogCollectionSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DiagnosticProactiveLogCollectionSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticProactiveLogCollectionSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
