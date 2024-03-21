// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Represents applicable recovery vm sizes properties. </summary>
    public partial class TargetComputeSizeProperties
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

        /// <summary> Initializes a new instance of <see cref="TargetComputeSizeProperties"/>. </summary>
        internal TargetComputeSizeProperties()
        {
            Errors = new ChangeTrackingList<SiteRecoveryComputeSizeErrorDetails>();
            HyperVGenerations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="TargetComputeSizeProperties"/>. </summary>
        /// <param name="name"> Target compute size name. </param>
        /// <param name="friendlyName"> Target compute size display name. </param>
        /// <param name="cpuCoresCount"> The maximum cpu cores count supported by target compute size. </param>
        /// <param name="vCpusAvailable"> The Available vCPUs supported by target compute size. </param>
        /// <param name="memoryInGB"> The maximum memory in GB supported by target compute size. </param>
        /// <param name="maxDataDiskCount"> The maximum data disks count supported by target compute size. </param>
        /// <param name="maxNicsCount"> The maximum Nics count supported by target compute size. </param>
        /// <param name="errors"> The reasons why the target compute size is not applicable for the protected item. </param>
        /// <param name="highIopsSupported"> The value indicating whether the target compute size supports high Iops. </param>
        /// <param name="hyperVGenerations"> The supported HyperV Generations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetComputeSizeProperties(string name, string friendlyName, int? cpuCoresCount, int? vCpusAvailable, double? memoryInGB, int? maxDataDiskCount, int? maxNicsCount, IReadOnlyList<SiteRecoveryComputeSizeErrorDetails> errors, string highIopsSupported, IReadOnlyList<string> hyperVGenerations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            FriendlyName = friendlyName;
            CpuCoresCount = cpuCoresCount;
            VCpusAvailable = vCpusAvailable;
            MemoryInGB = memoryInGB;
            MaxDataDiskCount = maxDataDiskCount;
            MaxNicsCount = maxNicsCount;
            Errors = errors;
            HighIopsSupported = highIopsSupported;
            HyperVGenerations = hyperVGenerations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Target compute size name. </summary>
        public string Name { get; }
        /// <summary> Target compute size display name. </summary>
        public string FriendlyName { get; }
        /// <summary> The maximum cpu cores count supported by target compute size. </summary>
        public int? CpuCoresCount { get; }
        /// <summary> The Available vCPUs supported by target compute size. </summary>
        public int? VCpusAvailable { get; }
        /// <summary> The maximum memory in GB supported by target compute size. </summary>
        public double? MemoryInGB { get; }
        /// <summary> The maximum data disks count supported by target compute size. </summary>
        public int? MaxDataDiskCount { get; }
        /// <summary> The maximum Nics count supported by target compute size. </summary>
        public int? MaxNicsCount { get; }
        /// <summary> The reasons why the target compute size is not applicable for the protected item. </summary>
        public IReadOnlyList<SiteRecoveryComputeSizeErrorDetails> Errors { get; }
        /// <summary> The value indicating whether the target compute size supports high Iops. </summary>
        public string HighIopsSupported { get; }
        /// <summary> The supported HyperV Generations. </summary>
        public IReadOnlyList<string> HyperVGenerations { get; }
    }
}
