// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role definition create parameters. </summary>
    internal partial class RoleDefinitionCreateParameters
    {
        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/>. </summary>
        /// <param name="properties"> Role definition properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RoleDefinitionCreateParameters(RoleDefinitionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Role definition properties. </summary>
        public RoleDefinitionProperties Properties { get; }
    }
}
