// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StartDataFlowDebugSessionRequestConverter))]
    public partial class StartDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlow))
            {
                writer.WritePropertyName("dataFlow"u8);
                writer.WriteObjectValue(DataFlow);
            }
            if (Optional.IsCollectionDefined(DataFlows))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging"u8);
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(DebugSettings))
            {
                writer.WritePropertyName("debugSettings"u8);
                writer.WriteObjectValue(DebugSettings);
            }
            if (Optional.IsDefined(IncrementalDebug))
            {
                writer.WritePropertyName("incrementalDebug"u8);
                writer.WriteBooleanValue(IncrementalDebug.Value);
            }
            writer.WriteEndObject();
        }

        internal static StartDataFlowDebugSessionRequest DeserializeStartDataFlowDebugSessionRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sessionId = default;
            DataFlowResource dataFlow = default;
            IList<DataFlowResource> dataFlows = default;
            IList<DatasetResource> datasets = default;
            IList<LinkedServiceResource> linkedServices = default;
            object staging = default;
            object debugSettings = default;
            bool? incrementalDebug = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlow = DataFlowResource.DeserializeDataFlowResource(property.Value);
                    continue;
                }
                if (property.NameEquals("dataFlows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowResource> array = new List<DataFlowResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowResource.DeserializeDataFlowResource(item));
                    }
                    dataFlows = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetResource> array = new List<DatasetResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetResource.DeserializeDatasetResource(item));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedServiceResource> array = new List<LinkedServiceResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceResource.DeserializeLinkedServiceResource(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("staging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staging = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("debugSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSettings = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("incrementalDebug"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incrementalDebug = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StartDataFlowDebugSessionRequest(
                sessionId,
                dataFlow,
                dataFlows ?? new ChangeTrackingList<DataFlowResource>(),
                datasets ?? new ChangeTrackingList<DatasetResource>(),
                linkedServices ?? new ChangeTrackingList<LinkedServiceResource>(),
                staging,
                debugSettings,
                incrementalDebug);
        }

        internal partial class StartDataFlowDebugSessionRequestConverter : JsonConverter<StartDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, StartDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StartDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStartDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
