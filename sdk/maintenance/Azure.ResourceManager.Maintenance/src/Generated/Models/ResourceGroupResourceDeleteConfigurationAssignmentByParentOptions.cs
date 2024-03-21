// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> The ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions. </summary>
    public partial class ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions
    {
        /// <summary> Initializes a new instance of <see cref="ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions"/>. </summary>
        /// <param name="providerName"> Resource provider name. </param>
        /// <param name="resourceParentType"> Resource parent type. </param>
        /// <param name="resourceParentName"> Resource parent identifier. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceName"> Resource identifier. </param>
        /// <param name="configurationAssignmentName"> Unique configuration assignment name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceParentType"/>, <paramref name="resourceParentName"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="configurationAssignmentName"/> is null. </exception>
        public ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions(string providerName, string resourceParentType, string resourceParentName, string resourceType, string resourceName, string configurationAssignmentName)
        {
            Argument.AssertNotNull(providerName, nameof(providerName));
            Argument.AssertNotNull(resourceParentType, nameof(resourceParentType));
            Argument.AssertNotNull(resourceParentName, nameof(resourceParentName));
            Argument.AssertNotNull(resourceType, nameof(resourceType));
            Argument.AssertNotNull(resourceName, nameof(resourceName));
            Argument.AssertNotNull(configurationAssignmentName, nameof(configurationAssignmentName));

            ProviderName = providerName;
            ResourceParentType = resourceParentType;
            ResourceParentName = resourceParentName;
            ResourceType = resourceType;
            ResourceName = resourceName;
            ConfigurationAssignmentName = configurationAssignmentName;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions"/> for deserialization. </summary>
        internal ResourceGroupResourceDeleteConfigurationAssignmentByParentOptions()
        {
        }

        /// <summary> Resource provider name. </summary>
        public string ProviderName { get; }
        /// <summary> Resource parent type. </summary>
        public string ResourceParentType { get; }
        /// <summary> Resource parent identifier. </summary>
        public string ResourceParentName { get; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Resource identifier. </summary>
        public string ResourceName { get; }
        /// <summary> Unique configuration assignment name. </summary>
        public string ConfigurationAssignmentName { get; }
    }
}
