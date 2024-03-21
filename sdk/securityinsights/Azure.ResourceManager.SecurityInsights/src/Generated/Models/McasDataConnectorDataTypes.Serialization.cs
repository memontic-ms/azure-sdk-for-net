// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class McasDataConnectorDataTypes : IUtf8JsonSerializable, IJsonModel<McasDataConnectorDataTypes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<McasDataConnectorDataTypes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<McasDataConnectorDataTypes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiscoveryLogs))
            {
                writer.WritePropertyName("discoveryLogs"u8);
                writer.WriteObjectValue(DiscoveryLogs);
            }
            if (Optional.IsDefined(Alerts))
            {
                writer.WritePropertyName("alerts"u8);
                writer.WriteObjectValue(Alerts);
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

        McasDataConnectorDataTypes IJsonModel<McasDataConnectorDataTypes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
        }

        internal static McasDataConnectorDataTypes DeserializeMcasDataConnectorDataTypes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataConnectorDataTypeCommon discoveryLogs = default;
            DataConnectorDataTypeCommon alerts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("discoveryLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveryLogs = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("alerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alerts = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new McasDataConnectorDataTypes(alerts, serializedAdditionalRawData, discoveryLogs);
        }

        BinaryData IPersistableModel<McasDataConnectorDataTypes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }
        }

        McasDataConnectorDataTypes IPersistableModel<McasDataConnectorDataTypes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<McasDataConnectorDataTypes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
