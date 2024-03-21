// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Information about a service principal identity for the cluster to use for manipulating Azure APIs. </summary>
    public partial class ManagedClusterServicePrincipalProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterServicePrincipalProfile"/>. </summary>
        /// <param name="clientId"> The ID for the service principal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> is null. </exception>
        public ManagedClusterServicePrincipalProfile(string clientId)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));

            ClientId = clientId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterServicePrincipalProfile"/>. </summary>
        /// <param name="clientId"> The ID for the service principal. </param>
        /// <param name="secret"> The secret password associated with the service principal in plain text. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterServicePrincipalProfile(string clientId, string secret, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClientId = clientId;
            Secret = secret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterServicePrincipalProfile"/> for deserialization. </summary>
        internal ManagedClusterServicePrincipalProfile()
        {
        }

        /// <summary> The ID for the service principal. </summary>
        public string ClientId { get; set; }
        /// <summary> The secret password associated with the service principal in plain text. </summary>
        public string Secret { get; set; }
    }
}
