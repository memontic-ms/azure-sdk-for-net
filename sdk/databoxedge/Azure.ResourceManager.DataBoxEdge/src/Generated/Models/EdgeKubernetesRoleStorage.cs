// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes role storage resource. </summary>
    public partial class EdgeKubernetesRoleStorage
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

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleStorage"/>. </summary>
        public EdgeKubernetesRoleStorage()
        {
            StorageClasses = new ChangeTrackingList<EdgeKubernetesRoleStorageClassInfo>();
            Endpoints = new ChangeTrackingList<DataBoxEdgeMountPointMap>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleStorage"/>. </summary>
        /// <param name="storageClasses"> Kubernetes storage class info. </param>
        /// <param name="endpoints"> Mount points of shares in role(s). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeKubernetesRoleStorage(IReadOnlyList<EdgeKubernetesRoleStorageClassInfo> storageClasses, IList<DataBoxEdgeMountPointMap> endpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageClasses = storageClasses;
            Endpoints = endpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Kubernetes storage class info. </summary>
        public IReadOnlyList<EdgeKubernetesRoleStorageClassInfo> StorageClasses { get; }
        /// <summary> Mount points of shares in role(s). </summary>
        public IList<DataBoxEdgeMountPointMap> Endpoints { get; }
    }
}
