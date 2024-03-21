// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra view resource object. </summary>
    public partial class CassandraViewResource
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="viewDefinition"/> is null. </exception>
        public CassandraViewResource(string id, string viewDefinition)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(viewDefinition, nameof(viewDefinition));

            Id = id;
            ViewDefinition = viewDefinition;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraViewResource(string id, string viewDefinition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ViewDefinition = viewDefinition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/> for deserialization. </summary>
        internal CassandraViewResource()
        {
        }

        /// <summary> Name of the Cosmos DB Cassandra view. </summary>
        public string Id { get; set; }
        /// <summary> View Definition of the Cosmos DB Cassandra view. </summary>
        public string ViewDefinition { get; set; }
    }
}
