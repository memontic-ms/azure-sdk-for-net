// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Gets the request plans with indication on each plan whether is approved by the admin, has pending request or not requested yet. </summary>
    public partial class QueryApprovalRequestResult
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

        /// <summary> Initializes a new instance of <see cref="QueryApprovalRequestResult"/>. </summary>
        internal QueryApprovalRequestResult()
        {
            PlansDetails = new ChangeTrackingDictionary<string, PrivateStorePlanDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryApprovalRequestResult"/>. </summary>
        /// <param name="uniqueOfferId"> Gets or sets unique offer id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="eTag"> Gets or sets e-tag field. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryApprovalRequestResult(string uniqueOfferId, IReadOnlyDictionary<string, PrivateStorePlanDetails> plansDetails, ETag? eTag, long? messageCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UniqueOfferId = uniqueOfferId;
            PlansDetails = plansDetails;
            ETag = eTag;
            MessageCode = messageCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets unique offer id. </summary>
        public string UniqueOfferId { get; }
        /// <summary> Gets or sets the plans details. </summary>
        public IReadOnlyDictionary<string, PrivateStorePlanDetails> PlansDetails { get; }
        /// <summary> Gets or sets e-tag field. </summary>
        public ETag? ETag { get; }
        /// <summary> Gets or sets the notification message id. </summary>
        public long? MessageCode { get; }
    }
}
