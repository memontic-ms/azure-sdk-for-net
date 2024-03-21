// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the IPGroup data model.
    /// The IpGroups resource information.
    /// </summary>
    public partial class IPGroupData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="IPGroupData"/>. </summary>
        public IPGroupData()
        {
            IPAddresses = new ChangeTrackingList<string>();
            Firewalls = new ChangeTrackingList<WritableSubResource>();
            FirewallPolicies = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="IPGroupData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the IpGroups resource. </param>
        /// <param name="ipAddresses"> IpAddresses/IpAddressPrefixes in the IpGroups resource. </param>
        /// <param name="firewalls"> List of references to Firewall resources that this IpGroups is associated with. </param>
        /// <param name="firewallPolicies"> List of references to Firewall Policies resources that this IpGroups is associated with. </param>
        internal IPGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, NetworkProvisioningState? provisioningState, IList<string> ipAddresses, IReadOnlyList<WritableSubResource> firewalls, IReadOnlyList<WritableSubResource> firewallPolicies) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            IPAddresses = ipAddresses;
            Firewalls = firewalls;
            FirewallPolicies = firewallPolicies;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the IpGroups resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> IpAddresses/IpAddressPrefixes in the IpGroups resource. </summary>
        public IList<string> IPAddresses { get; }
        /// <summary> List of references to Firewall resources that this IpGroups is associated with. </summary>
        public IReadOnlyList<WritableSubResource> Firewalls { get; }
        /// <summary> List of references to Firewall Policies resources that this IpGroups is associated with. </summary>
        public IReadOnlyList<WritableSubResource> FirewallPolicies { get; }
    }
}
