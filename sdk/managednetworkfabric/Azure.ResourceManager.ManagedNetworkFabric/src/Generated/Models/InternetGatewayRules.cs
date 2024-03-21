// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Rules for the InternetGateways. </summary>
    public partial class InternetGatewayRules
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

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRules"/>. </summary>
        /// <param name="action"> Specify action. </param>
        /// <param name="addressList"> List of Addresses to be allowed or denied. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressList"/> is null. </exception>
        public InternetGatewayRules(InternetGatewayRuleAction action, IEnumerable<string> addressList)
        {
            Argument.AssertNotNull(addressList, nameof(addressList));

            Action = action;
            AddressList = addressList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRules"/>. </summary>
        /// <param name="action"> Specify action. </param>
        /// <param name="addressList"> List of Addresses to be allowed or denied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternetGatewayRules(InternetGatewayRuleAction action, IList<string> addressList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            AddressList = addressList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRules"/> for deserialization. </summary>
        internal InternetGatewayRules()
        {
        }

        /// <summary> Specify action. </summary>
        public InternetGatewayRuleAction Action { get; set; }
        /// <summary> List of Addresses to be allowed or denied. </summary>
        public IList<string> AddressList { get; }
    }
}
