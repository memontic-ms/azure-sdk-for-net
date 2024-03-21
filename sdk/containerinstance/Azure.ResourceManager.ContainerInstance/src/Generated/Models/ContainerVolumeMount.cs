// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The properties of the volume mount. </summary>
    public partial class ContainerVolumeMount
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

        /// <summary> Initializes a new instance of <see cref="ContainerVolumeMount"/>. </summary>
        /// <param name="name"> The name of the volume mount. </param>
        /// <param name="mountPath"> The path within the container where the volume should be mounted. Must not contain colon (:). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mountPath"/> is null. </exception>
        public ContainerVolumeMount(string name, string mountPath)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(mountPath, nameof(mountPath));

            Name = name;
            MountPath = mountPath;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerVolumeMount"/>. </summary>
        /// <param name="name"> The name of the volume mount. </param>
        /// <param name="mountPath"> The path within the container where the volume should be mounted. Must not contain colon (:). </param>
        /// <param name="isReadOnly"> The flag indicating whether the volume mount is read-only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerVolumeMount(string name, string mountPath, bool? isReadOnly, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MountPath = mountPath;
            IsReadOnly = isReadOnly;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerVolumeMount"/> for deserialization. </summary>
        internal ContainerVolumeMount()
        {
        }

        /// <summary> The name of the volume mount. </summary>
        public string Name { get; set; }
        /// <summary> The path within the container where the volume should be mounted. Must not contain colon (:). </summary>
        public string MountPath { get; set; }
        /// <summary> The flag indicating whether the volume mount is read-only. </summary>
        public bool? IsReadOnly { get; set; }
    }
}
