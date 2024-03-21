// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The aggregation expression to be used in the report. </summary>
    public partial class ReportConfigAggregation
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

        /// <summary> Initializes a new instance of <see cref="ReportConfigAggregation"/>. </summary>
        /// <param name="name"> The name of the column to aggregate. </param>
        /// <param name="function"> The name of the aggregation function to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ReportConfigAggregation(string name, FunctionType function)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Function = function;
        }

        /// <summary> Initializes a new instance of <see cref="ReportConfigAggregation"/>. </summary>
        /// <param name="name"> The name of the column to aggregate. </param>
        /// <param name="function"> The name of the aggregation function to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportConfigAggregation(string name, FunctionType function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Function = function;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReportConfigAggregation"/> for deserialization. </summary>
        internal ReportConfigAggregation()
        {
        }

        /// <summary> The name of the column to aggregate. </summary>
        public string Name { get; set; }
        /// <summary> The name of the aggregation function to use. </summary>
        public FunctionType Function { get; set; }
    }
}
