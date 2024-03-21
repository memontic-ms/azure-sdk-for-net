// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The job error information containing the list of job errors. </summary>
    public partial class DataBoxEdgeJobErrorDetails
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeJobErrorDetails"/>. </summary>
        internal DataBoxEdgeJobErrorDetails()
        {
            ErrorDetails = new ChangeTrackingList<DataBoxEdgeJobErrorItem>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeJobErrorDetails"/>. </summary>
        /// <param name="errorDetails"> The error details. </param>
        /// <param name="code"> The code intended for programmatic access. </param>
        /// <param name="message"> The message that describes the error in detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeJobErrorDetails(IReadOnlyList<DataBoxEdgeJobErrorItem> errorDetails, string code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorDetails = errorDetails;
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error details. </summary>
        public IReadOnlyList<DataBoxEdgeJobErrorItem> ErrorDetails { get; }
        /// <summary> The code intended for programmatic access. </summary>
        public string Code { get; }
        /// <summary> The message that describes the error in detail. </summary>
        public string Message { get; }
    }
}
