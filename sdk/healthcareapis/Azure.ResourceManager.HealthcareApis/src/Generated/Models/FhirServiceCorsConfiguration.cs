// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The settings for the CORS configuration of the service instance. </summary>
    public partial class FhirServiceCorsConfiguration
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

        /// <summary> Initializes a new instance of <see cref="FhirServiceCorsConfiguration"/>. </summary>
        public FhirServiceCorsConfiguration()
        {
            Origins = new ChangeTrackingList<string>();
            Headers = new ChangeTrackingList<string>();
            Methods = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirServiceCorsConfiguration"/>. </summary>
        /// <param name="origins"> The origins to be allowed via CORS. </param>
        /// <param name="headers"> The headers to be allowed via CORS. </param>
        /// <param name="methods"> The methods to be allowed via CORS. </param>
        /// <param name="maxAge"> The max age to be allowed via CORS. </param>
        /// <param name="allowCredentials"> If credentials are allowed via CORS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FhirServiceCorsConfiguration(IList<string> origins, IList<string> headers, IList<string> methods, int? maxAge, bool? allowCredentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Origins = origins;
            Headers = headers;
            Methods = methods;
            MaxAge = maxAge;
            AllowCredentials = allowCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The origins to be allowed via CORS. </summary>
        public IList<string> Origins { get; }
        /// <summary> The headers to be allowed via CORS. </summary>
        public IList<string> Headers { get; }
        /// <summary> The methods to be allowed via CORS. </summary>
        public IList<string> Methods { get; }
        /// <summary> The max age to be allowed via CORS. </summary>
        public int? MaxAge { get; set; }
        /// <summary> If credentials are allowed via CORS. </summary>
        public bool? AllowCredentials { get; set; }
    }
}
