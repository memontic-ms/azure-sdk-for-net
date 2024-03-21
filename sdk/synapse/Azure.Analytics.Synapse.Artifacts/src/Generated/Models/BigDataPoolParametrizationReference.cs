// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Big data pool reference type. </summary>
    public partial class BigDataPoolParametrizationReference
    {
        /// <summary> Initializes a new instance of <see cref="BigDataPoolParametrizationReference"/>. </summary>
        /// <param name="type"> Big data pool reference type. </param>
        /// <param name="referenceName"> Reference big data pool name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public BigDataPoolParametrizationReference(BigDataPoolReferenceType type, object referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Big data pool reference type. </summary>
        public BigDataPoolReferenceType Type { get; set; }
        /// <summary> Reference big data pool name. Type: string (or Expression with resultType string). </summary>
        public object ReferenceName { get; set; }
    }
}
