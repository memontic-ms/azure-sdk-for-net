// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Specifies the vectorization method to be used during query time.
    /// Please note <see cref="VectorSearchVectorizer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureOpenAIVectorizer"/> and <see cref="CustomVectorizer"/>.
    /// </summary>
    public abstract partial class VectorSearchVectorizer
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearchVectorizer"/>. </summary>
        /// <param name="name"> The name to associate with this particular vectorization method. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected VectorSearchVectorizer(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="VectorSearchVectorizer"/>. </summary>
        /// <param name="name"> The name to associate with this particular vectorization method. </param>
        /// <param name="kind"> The name of the kind of vectorization method being configured for use with vector search. </param>
        internal VectorSearchVectorizer(string name, VectorSearchVectorizerKind kind)
        {
            Name = name;
            Kind = kind;
        }

        /// <summary> The name to associate with this particular vectorization method. </summary>
        public string Name { get; set; }
        /// <summary> The name of the kind of vectorization method being configured for use with vector search. </summary>
        internal VectorSearchVectorizerKind Kind { get; set; }
    }
}
