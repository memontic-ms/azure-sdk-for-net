// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the DdosCustomPolicy data model.
    /// A DDoS custom policy in a resource group.
    /// </summary>
    public partial class DdosCustomPolicyData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DdosCustomPolicyData"/>. </summary>
        public DdosCustomPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DdosCustomPolicyData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </param>
        /// <param name="provisioningState"> The provisioning state of the DDoS custom policy resource. </param>
        internal DdosCustomPolicyData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the DDoS custom policy resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
