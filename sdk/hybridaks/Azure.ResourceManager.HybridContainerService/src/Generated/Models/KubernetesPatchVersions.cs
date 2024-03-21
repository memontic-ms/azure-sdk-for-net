// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Kubernetes Patch Version profile. </summary>
    public partial class KubernetesPatchVersions
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

        /// <summary> Initializes a new instance of <see cref="KubernetesPatchVersions"/>. </summary>
        internal KubernetesPatchVersions()
        {
            Readiness = new ChangeTrackingList<KubernetesVersionReadiness>();
            Upgrades = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesPatchVersions"/>. </summary>
        /// <param name="readiness"> Indicates whether the kubernetes version image is ready or not. </param>
        /// <param name="upgrades"> Possible upgrade paths for given patch version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesPatchVersions(IReadOnlyList<KubernetesVersionReadiness> readiness, IReadOnlyList<string> upgrades, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Readiness = readiness;
            Upgrades = upgrades;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the kubernetes version image is ready or not. </summary>
        public IReadOnlyList<KubernetesVersionReadiness> Readiness { get; }
        /// <summary> Possible upgrade paths for given patch version. </summary>
        public IReadOnlyList<string> Upgrades { get; }
    }
}
