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
    /// A class representing the ApplicationSecurityGroup data model.
    /// An application security group in a resource group.
    /// </summary>
    public partial class ApplicationSecurityGroupData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationSecurityGroupData"/>. </summary>
        public ApplicationSecurityGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationSecurityGroupData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </param>
        /// <param name="provisioningState"> The provisioning state of the application security group resource. </param>
        internal ApplicationSecurityGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the application security group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
