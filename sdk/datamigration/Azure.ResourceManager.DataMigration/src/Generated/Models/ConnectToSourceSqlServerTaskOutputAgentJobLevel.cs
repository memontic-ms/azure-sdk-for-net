// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Agent Job level output for the task that validates connection to SQL Server and also validates source server requirements. </summary>
    public partial class ConnectToSourceSqlServerTaskOutputAgentJobLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutputAgentJobLevel"/>. </summary>
        internal ConnectToSourceSqlServerTaskOutputAgentJobLevel()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
            ResultType = "AgentJobLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutputAgentJobLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Type of result - database level or task level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Agent Job name. </param>
        /// <param name="jobCategory"> The type of Agent Job. </param>
        /// <param name="isEnabled"> The state of the original Agent Job. </param>
        /// <param name="jobOwner"> The owner of the Agent Job. </param>
        /// <param name="lastExecutedOn"> UTC Date and time when the Agent Job was last executed. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="migrationEligibility"> Information about eligibility of agent job for migration. </param>
        internal ConnectToSourceSqlServerTaskOutputAgentJobLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, string jobCategory, bool? isEnabled, string jobOwner, DateTimeOffset? lastExecutedOn, IReadOnlyList<ReportableException> validationErrors, MigrationEligibilityInfo migrationEligibility) : base(id, resultType, serializedAdditionalRawData)
        {
            Name = name;
            JobCategory = jobCategory;
            IsEnabled = isEnabled;
            JobOwner = jobOwner;
            LastExecutedOn = lastExecutedOn;
            ValidationErrors = validationErrors;
            MigrationEligibility = migrationEligibility;
            ResultType = resultType ?? "AgentJobLevelOutput";
        }

        /// <summary> Agent Job name. </summary>
        public string Name { get; }
        /// <summary> The type of Agent Job. </summary>
        public string JobCategory { get; }
        /// <summary> The state of the original Agent Job. </summary>
        public bool? IsEnabled { get; }
        /// <summary> The owner of the Agent Job. </summary>
        public string JobOwner { get; }
        /// <summary> UTC Date and time when the Agent Job was last executed. </summary>
        public DateTimeOffset? LastExecutedOn { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
        /// <summary> Information about eligibility of agent job for migration. </summary>
        public MigrationEligibilityInfo MigrationEligibility { get; }
    }
}
