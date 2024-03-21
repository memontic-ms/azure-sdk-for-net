// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The role based access control (RBAC) authorization type integration runtime. </summary>
    public partial class SynapseLinkedIntegrationRuntimeRbacAuthorization : SynapseLinkedIntegrationRuntimeType
    {
        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/>. </summary>
        /// <param name="resourceId"> The resource identifier of the integration runtime to be shared. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public SynapseLinkedIntegrationRuntimeRbacAuthorization(ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
            AuthorizationType = "RBAC";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/>. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resourceId"> The resource identifier of the integration runtime to be shared. </param>
        internal SynapseLinkedIntegrationRuntimeRbacAuthorization(string authorizationType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier resourceId) : base(authorizationType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            AuthorizationType = authorizationType ?? "RBAC";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/> for deserialization. </summary>
        internal SynapseLinkedIntegrationRuntimeRbacAuthorization()
        {
        }

        /// <summary> The resource identifier of the integration runtime to be shared. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
