// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 specific provider input. </summary>
    public partial class InMageReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageReprotectContent"/>. </summary>
        /// <param name="masterTargetId"> The Master Target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="retentionDrive"> The retention drive to use on the MT. </param>
        /// <param name="profileId"> The Policy Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="masterTargetId"/>, <paramref name="retentionDrive"/> or <paramref name="profileId"/> is null. </exception>
        public InMageReprotectContent(string masterTargetId, Guid processServerId, string retentionDrive, string profileId)
        {
            Argument.AssertNotNull(masterTargetId, nameof(masterTargetId));
            Argument.AssertNotNull(retentionDrive, nameof(retentionDrive));
            Argument.AssertNotNull(profileId, nameof(profileId));

            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            ProfileId = profileId;
            DisksToInclude = new ChangeTrackingList<string>();
            InstanceType = "InMage";
        }

        /// <summary> Initializes a new instance of <see cref="InMageReprotectContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="masterTargetId"> The Master Target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="retentionDrive"> The retention drive to use on the MT. </param>
        /// <param name="runAsAccountId"> The CS account Id. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="diskExclusionContent"> The enable disk exclusion input. </param>
        /// <param name="profileId"> The Policy Id. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        internal InMageReprotectContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string masterTargetId, Guid processServerId, string retentionDrive, string runAsAccountId, string datastoreName, InMageDiskExclusionContent diskExclusionContent, string profileId, IList<string> disksToInclude) : base(instanceType, serializedAdditionalRawData)
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            RunAsAccountId = runAsAccountId;
            DatastoreName = datastoreName;
            DiskExclusionContent = diskExclusionContent;
            ProfileId = profileId;
            DisksToInclude = disksToInclude;
            InstanceType = instanceType ?? "InMage";
        }

        /// <summary> Initializes a new instance of <see cref="InMageReprotectContent"/> for deserialization. </summary>
        internal InMageReprotectContent()
        {
        }

        /// <summary> The Master Target Id. </summary>
        public string MasterTargetId { get; }
        /// <summary> The Process Server Id. </summary>
        public Guid ProcessServerId { get; }
        /// <summary> The retention drive to use on the MT. </summary>
        public string RetentionDrive { get; }
        /// <summary> The CS account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> The target datastore name. </summary>
        public string DatastoreName { get; set; }
        /// <summary> The enable disk exclusion input. </summary>
        public InMageDiskExclusionContent DiskExclusionContent { get; set; }
        /// <summary> The Policy Id. </summary>
        public string ProfileId { get; }
        /// <summary> The disks to include list. </summary>
        public IList<string> DisksToInclude { get; }
    }
}
