// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFlowDebugCommandContent : IUtf8JsonSerializable, IJsonModel<DataFlowDebugCommandContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlowDebugCommandContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFlowDebugCommandContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugCommandContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowDebugCommandContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command.Value.ToString());
            }
            if (Optional.IsDefined(CommandPayload))
            {
                writer.WritePropertyName("commandPayload"u8);
                writer.WriteObjectValue(CommandPayload);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataFlowDebugCommandContent IJsonModel<DataFlowDebugCommandContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugCommandContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowDebugCommandContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugCommandContent(document.RootElement, options);
        }

        internal static DataFlowDebugCommandContent DeserializeDataFlowDebugCommandContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            DataFlowDebugCommandType? command = default;
            DataFlowDebugCommandPayload commandPayload = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("command"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    command = new DataFlowDebugCommandType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commandPayload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commandPayload = DataFlowDebugCommandPayload.DeserializeDataFlowDebugCommandPayload(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFlowDebugCommandContent(sessionId, command, commandPayload, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFlowDebugCommandContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugCommandContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFlowDebugCommandContent)} does not support '{options.Format}' format.");
            }
        }

        DataFlowDebugCommandContent IPersistableModel<DataFlowDebugCommandContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugCommandContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFlowDebugCommandContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFlowDebugCommandContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFlowDebugCommandContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
