// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> SSIS properties for managed integration runtime. </summary>
    public partial class SynapseIntegrationRuntimeSsisProperties
    {
        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeSsisProperties"/>. </summary>
        public SynapseIntegrationRuntimeSsisProperties()
        {
            ExpressCustomSetupProperties = new ChangeTrackingList<SynapseCustomSetupBase>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeSsisProperties"/>. </summary>
        /// <param name="catalogInfo"> Catalog information for managed dedicated integration runtime. </param>
        /// <param name="licenseType"> License type for bringing your own license scenario. </param>
        /// <param name="customSetupScriptProperties"> Custom setup script properties for a managed dedicated integration runtime. </param>
        /// <param name="dataProxyProperties"> Data proxy properties for a managed dedicated integration runtime. </param>
        /// <param name="edition"> The edition for the SSIS Integration Runtime. </param>
        /// <param name="expressCustomSetupProperties">
        /// Custom setup without script properties for a SSIS integration runtime.
        /// Please note <see cref="SynapseCustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseCmdkeySetup"/>, <see cref="SynapseComponentSetup"/> and <see cref="SynapseEnvironmentVariableSetup"/>.
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SynapseIntegrationRuntimeSsisProperties(SynapseIntegrationRuntimeSsisCatalogInfo catalogInfo, SynapseIntegrationRuntimeLicenseType? licenseType, SynapseIntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties, SynapseIntegrationRuntimeDataProxyProperties dataProxyProperties, SynapseIntegrationRuntimeEdition? edition, IList<SynapseCustomSetupBase> expressCustomSetupProperties, IDictionary<string, BinaryData> additionalProperties)
        {
            CatalogInfo = catalogInfo;
            LicenseType = licenseType;
            CustomSetupScriptProperties = customSetupScriptProperties;
            DataProxyProperties = dataProxyProperties;
            Edition = edition;
            ExpressCustomSetupProperties = expressCustomSetupProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Catalog information for managed dedicated integration runtime. </summary>
        public SynapseIntegrationRuntimeSsisCatalogInfo CatalogInfo { get; set; }
        /// <summary> License type for bringing your own license scenario. </summary>
        public SynapseIntegrationRuntimeLicenseType? LicenseType { get; set; }
        /// <summary> Custom setup script properties for a managed dedicated integration runtime. </summary>
        public SynapseIntegrationRuntimeCustomSetupScriptProperties CustomSetupScriptProperties { get; set; }
        /// <summary> Data proxy properties for a managed dedicated integration runtime. </summary>
        public SynapseIntegrationRuntimeDataProxyProperties DataProxyProperties { get; set; }
        /// <summary> The edition for the SSIS Integration Runtime. </summary>
        public SynapseIntegrationRuntimeEdition? Edition { get; set; }
        /// <summary>
        /// Custom setup without script properties for a SSIS integration runtime.
        /// Please note <see cref="SynapseCustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseCmdkeySetup"/>, <see cref="SynapseComponentSetup"/> and <see cref="SynapseEnvironmentVariableSetup"/>.
        /// </summary>
        public IList<SynapseCustomSetupBase> ExpressCustomSetupProperties { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
