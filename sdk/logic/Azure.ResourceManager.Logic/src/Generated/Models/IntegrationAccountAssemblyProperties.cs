// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The assembly properties definition. </summary>
    public partial class IntegrationAccountAssemblyProperties : ArtifactContentProperties
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAssemblyProperties"/>. </summary>
        /// <param name="assemblyName"> The assembly name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assemblyName"/> is null. </exception>
        public IntegrationAccountAssemblyProperties(string assemblyName)
        {
            Argument.AssertNotNull(assemblyName, nameof(assemblyName));

            AssemblyName = assemblyName;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAssemblyProperties"/>. </summary>
        /// <param name="createdOn"> The artifact creation time. </param>
        /// <param name="changedOn"> The artifact changed time. </param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> Anything. </param>
        /// <param name="contentType"> The content type. </param>
        /// <param name="contentLink"> The content link. </param>
        /// <param name="assemblyName"> The assembly name. </param>
        /// <param name="assemblyVersion"> The assembly version. </param>
        /// <param name="assemblyCulture"> The assembly culture. </param>
        /// <param name="assemblyPublicKeyToken"> The assembly public key token. </param>
        internal IntegrationAccountAssemblyProperties(DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, IDictionary<string, BinaryData> serializedAdditionalRawData, BinaryData content, ContentType? contentType, LogicContentLink contentLink, string assemblyName, string assemblyVersion, string assemblyCulture, string assemblyPublicKeyToken) : base(createdOn, changedOn, metadata, serializedAdditionalRawData, content, contentType, contentLink)
        {
            AssemblyName = assemblyName;
            AssemblyVersion = assemblyVersion;
            AssemblyCulture = assemblyCulture;
            AssemblyPublicKeyToken = assemblyPublicKeyToken;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAssemblyProperties"/> for deserialization. </summary>
        internal IntegrationAccountAssemblyProperties()
        {
        }

        /// <summary> The assembly name. </summary>
        public string AssemblyName { get; set; }
        /// <summary> The assembly version. </summary>
        public string AssemblyVersion { get; set; }
        /// <summary> The assembly culture. </summary>
        public string AssemblyCulture { get; set; }
        /// <summary> The assembly public key token. </summary>
        public string AssemblyPublicKeyToken { get; set; }
    }
}
