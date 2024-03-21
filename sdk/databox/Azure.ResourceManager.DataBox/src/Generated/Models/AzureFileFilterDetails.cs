// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Filter details to transfer Azure files. </summary>
    public partial class AzureFileFilterDetails
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

        /// <summary> Initializes a new instance of <see cref="AzureFileFilterDetails"/>. </summary>
        public AzureFileFilterDetails()
        {
            FilePrefixList = new ChangeTrackingList<string>();
            FilePathList = new ChangeTrackingList<string>();
            FileShareList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureFileFilterDetails"/>. </summary>
        /// <param name="filePrefixList"> Prefix list of the Azure files to be transferred. </param>
        /// <param name="filePathList"> List of full path of the files to be transferred. </param>
        /// <param name="fileShareList"> List of file shares to be transferred. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureFileFilterDetails(IList<string> filePrefixList, IList<string> filePathList, IList<string> fileShareList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilePrefixList = filePrefixList;
            FilePathList = filePathList;
            FileShareList = fileShareList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Prefix list of the Azure files to be transferred. </summary>
        public IList<string> FilePrefixList { get; }
        /// <summary> List of full path of the files to be transferred. </summary>
        public IList<string> FilePathList { get; }
        /// <summary> List of file shares to be transferred. </summary>
        public IList<string> FileShareList { get; }
    }
}
