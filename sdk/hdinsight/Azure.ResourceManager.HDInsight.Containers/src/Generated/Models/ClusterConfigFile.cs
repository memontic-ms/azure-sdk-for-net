// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster configuration files. </summary>
    public partial class ClusterConfigFile
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

        /// <summary> Initializes a new instance of <see cref="ClusterConfigFile"/>. </summary>
        /// <param name="fileName"> Configuration file name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileName"/> is null. </exception>
        public ClusterConfigFile(string fileName)
        {
            Argument.AssertNotNull(fileName, nameof(fileName));

            FileName = fileName;
            Values = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterConfigFile"/>. </summary>
        /// <param name="fileName"> Configuration file name. </param>
        /// <param name="content"> Free form content of the entire configuration file. </param>
        /// <param name="encoding"> This property indicates if the content is encoded and is case-insensitive. Please set the value to base64 if the content is base64 encoded. Set it to none or skip it if the content is plain text. </param>
        /// <param name="path"> Path of the config file if content is specified. </param>
        /// <param name="values">
        /// List of key value pairs
        /// where key represents a valid service configuration name and value represents the value of the config.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterConfigFile(string fileName, string content, HDInsightContentEncoding? encoding, string path, IDictionary<string, string> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileName = fileName;
            Content = content;
            Encoding = encoding;
            Path = path;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterConfigFile"/> for deserialization. </summary>
        internal ClusterConfigFile()
        {
        }

        /// <summary> Configuration file name. </summary>
        public string FileName { get; set; }
        /// <summary> Free form content of the entire configuration file. </summary>
        public string Content { get; set; }
        /// <summary> This property indicates if the content is encoded and is case-insensitive. Please set the value to base64 if the content is base64 encoded. Set it to none or skip it if the content is plain text. </summary>
        public HDInsightContentEncoding? Encoding { get; set; }
        /// <summary> Path of the config file if content is specified. </summary>
        public string Path { get; set; }
        /// <summary>
        /// List of key value pairs
        /// where key represents a valid service configuration name and value represents the value of the config.
        /// </summary>
        public IDictionary<string, string> Values { get; }
    }
}
