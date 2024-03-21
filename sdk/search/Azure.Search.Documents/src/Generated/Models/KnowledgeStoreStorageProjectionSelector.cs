// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Abstract class to share properties between concrete selectors. </summary>
    public partial class KnowledgeStoreStorageProjectionSelector : KnowledgeStoreProjectionSelector
    {
        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreStorageProjectionSelector"/>. </summary>
        /// <param name="storageContainer"> Blob container to store projections in. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainer"/> is null. </exception>
        public KnowledgeStoreStorageProjectionSelector(string storageContainer)
        {
            Argument.AssertNotNull(storageContainer, nameof(storageContainer));

            StorageContainer = storageContainer;
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreStorageProjectionSelector"/>. </summary>
        /// <param name="referenceKeyName"> Name of reference key to different projection. </param>
        /// <param name="generatedKeyName"> Name of generated key to store projection under. </param>
        /// <param name="source"> Source data to project. </param>
        /// <param name="sourceContext"> Source context for complex projections. </param>
        /// <param name="inputs"> Nested inputs for complex projections. </param>
        /// <param name="storageContainer"> Blob container to store projections in. </param>
        internal KnowledgeStoreStorageProjectionSelector(string referenceKeyName, string generatedKeyName, string source, string sourceContext, IList<InputFieldMappingEntry> inputs, string storageContainer) : base(referenceKeyName, generatedKeyName, source, sourceContext, inputs)
        {
            StorageContainer = storageContainer;
        }

        /// <summary> Blob container to store projections in. </summary>
        public string StorageContainer { get; set; }
    }
}
