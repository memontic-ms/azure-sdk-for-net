// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBSyncTaskOutputDatabaseError. </summary>
    public partial class MigrateSqlServerSqlDBSyncTaskOutputDatabaseError : MigrateSqlServerSqlDBSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBSyncTaskOutputDatabaseError"/>. </summary>
        internal MigrateSqlServerSqlDBSyncTaskOutputDatabaseError()
        {
            Events = new ChangeTrackingList<SyncMigrationDatabaseErrorEvent>();
            ResultType = "DatabaseLevelErrorOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBSyncTaskOutputDatabaseError"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="errorMessage"> Error message. </param>
        /// <param name="events"> List of error events. </param>
        internal MigrateSqlServerSqlDBSyncTaskOutputDatabaseError(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string errorMessage, IReadOnlyList<SyncMigrationDatabaseErrorEvent> events) : base(id, resultType, serializedAdditionalRawData)
        {
            ErrorMessage = errorMessage;
            Events = events;
            ResultType = resultType ?? "DatabaseLevelErrorOutput";
        }

        /// <summary> Error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> List of error events. </summary>
        public IReadOnlyList<SyncMigrationDatabaseErrorEvent> Events { get; }
    }
}
