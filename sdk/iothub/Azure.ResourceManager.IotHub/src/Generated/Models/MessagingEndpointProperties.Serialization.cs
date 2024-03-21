// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class MessagingEndpointProperties : IUtf8JsonSerializable, IJsonModel<MessagingEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessagingEndpointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MessagingEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessagingEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessagingEndpointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LockDurationAsIso8601))
            {
                writer.WritePropertyName("lockDurationAsIso8601"u8);
                writer.WriteStringValue(LockDurationAsIso8601.Value, "P");
            }
            if (Optional.IsDefined(TtlAsIso8601))
            {
                writer.WritePropertyName("ttlAsIso8601"u8);
                writer.WriteStringValue(TtlAsIso8601.Value, "P");
            }
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
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

        MessagingEndpointProperties IJsonModel<MessagingEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessagingEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessagingEndpointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessagingEndpointProperties(document.RootElement, options);
        }

        internal static MessagingEndpointProperties DeserializeMessagingEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? lockDurationAsIso8601 = default;
            TimeSpan? ttlAsIso8601 = default;
            int? maxDeliveryCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lockDurationAsIso8601"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lockDurationAsIso8601 = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("ttlAsIso8601"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttlAsIso8601 = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxDeliveryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MessagingEndpointProperties(lockDurationAsIso8601, ttlAsIso8601, maxDeliveryCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MessagingEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessagingEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessagingEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        MessagingEndpointProperties IPersistableModel<MessagingEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessagingEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessagingEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessagingEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessagingEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
