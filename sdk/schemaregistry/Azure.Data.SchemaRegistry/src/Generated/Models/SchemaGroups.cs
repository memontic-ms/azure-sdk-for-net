// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> Object received from the registry containing the list of schema groups and link to next batch page. </summary>
    internal partial class SchemaGroups
    {
        /// <summary> Initializes a new instance of <see cref="SchemaGroups"/>. </summary>
        internal SchemaGroups()
        {
            Groups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SchemaGroups"/>. </summary>
        /// <param name="groups"> Array of schema groups. </param>
        /// <param name="nextLink"> URl to next batch of schema groups. </param>
        internal SchemaGroups(IReadOnlyList<string> groups, string nextLink)
        {
            Groups = groups;
            NextLink = nextLink;
        }

        /// <summary> Array of schema groups. </summary>
        public IReadOnlyList<string> Groups { get; }
        /// <summary> URl to next batch of schema groups. </summary>
        public string NextLink { get; }
    }
}
