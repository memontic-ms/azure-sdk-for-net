// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account Model. </summary>
    public partial class CognitiveServicesAccountModel : CognitiveServicesAccountDeploymentModel
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountModel"/>. </summary>
        public CognitiveServicesAccountModel()
        {
            Skus = new ChangeTrackingList<CognitiveServicesModelSku>();
            Capabilities = new ChangeTrackingDictionary<string, string>();
            FinetuneCapabilities = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountModel"/>. </summary>
        /// <param name="format"> Deployment model format. </param>
        /// <param name="name"> Deployment model name. </param>
        /// <param name="version"> Optional. Deployment model version. If version is not specified, a default version will be assigned. The default version is different for different models and might change when there is new version available for a model. Default version for a model could be found from list models API. </param>
        /// <param name="source"> Optional. Deployment model source ARM resource ID. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="baseModel"> Base Model Identifier. </param>
        /// <param name="isDefaultVersion"> If the model is default version. </param>
        /// <param name="skus"> The list of Model Sku. </param>
        /// <param name="maxCapacity"> The max capacity. </param>
        /// <param name="capabilities"> The capabilities. </param>
        /// <param name="finetuneCapabilities"> The capabilities for finetune models. </param>
        /// <param name="deprecation"> Cognitive Services account ModelDeprecationInfo. </param>
        /// <param name="lifecycleStatus"> Model lifecycle status. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal CognitiveServicesAccountModel(string format, string name, string version, string source, ServiceAccountCallRateLimit callRateLimit, IDictionary<string, BinaryData> serializedAdditionalRawData, CognitiveServicesAccountDeploymentModel baseModel, bool? isDefaultVersion, IList<CognitiveServicesModelSku> skus, int? maxCapacity, IDictionary<string, string> capabilities, IDictionary<string, string> finetuneCapabilities, ServiceAccountModelDeprecationInfo deprecation, ModelLifecycleStatus? lifecycleStatus, SystemData systemData) : base(format, name, version, source, callRateLimit, serializedAdditionalRawData)
        {
            BaseModel = baseModel;
            IsDefaultVersion = isDefaultVersion;
            Skus = skus;
            MaxCapacity = maxCapacity;
            Capabilities = capabilities;
            FinetuneCapabilities = finetuneCapabilities;
            Deprecation = deprecation;
            LifecycleStatus = lifecycleStatus;
            SystemData = systemData;
        }

        /// <summary> Base Model Identifier. </summary>
        public CognitiveServicesAccountDeploymentModel BaseModel { get; set; }
        /// <summary> If the model is default version. </summary>
        public bool? IsDefaultVersion { get; set; }
        /// <summary> The list of Model Sku. </summary>
        public IList<CognitiveServicesModelSku> Skus { get; }
        /// <summary> The max capacity. </summary>
        public int? MaxCapacity { get; set; }
        /// <summary> The capabilities. </summary>
        public IDictionary<string, string> Capabilities { get; }
        /// <summary> The capabilities for finetune models. </summary>
        public IDictionary<string, string> FinetuneCapabilities { get; }
        /// <summary> Cognitive Services account ModelDeprecationInfo. </summary>
        public ServiceAccountModelDeprecationInfo Deprecation { get; set; }
        /// <summary> Model lifecycle status. </summary>
        public ModelLifecycleStatus? LifecycleStatus { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
    }
}
