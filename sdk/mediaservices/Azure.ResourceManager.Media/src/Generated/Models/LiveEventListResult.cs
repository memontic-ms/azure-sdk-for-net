// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The LiveEvent list result. </summary>
    internal partial class LiveEventListResult
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

        /// <summary> Initializes a new instance of <see cref="LiveEventListResult"/>. </summary>
        internal LiveEventListResult()
        {
            Value = new ChangeTrackingList<MediaLiveEventData>();
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventListResult"/>. </summary>
        /// <param name="value"> The result of the List Live Event operation. </param>
        /// <param name="odataCount"> The number of result. </param>
        /// <param name="odataNextLink"> The link to the next set of results. Not empty if value contains incomplete list of live outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveEventListResult(IReadOnlyList<MediaLiveEventData> value, int? odataCount, string odataNextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            OdataCount = odataCount;
            OdataNextLink = odataNextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The result of the List Live Event operation. </summary>
        public IReadOnlyList<MediaLiveEventData> Value { get; }
        /// <summary> The number of result. </summary>
        public int? OdataCount { get; }
        /// <summary> The link to the next set of results. Not empty if value contains incomplete list of live outputs. </summary>
        public string OdataNextLink { get; }
    }
}
