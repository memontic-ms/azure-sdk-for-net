// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Unknown version of DataConnection. </summary>
    internal partial class UnknownDataConnection : KustoDataConnectionData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, location, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataConnection"/> for deserialization. </summary>
        internal UnknownDataConnection()
        {
        }
    }
}
