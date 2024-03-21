// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsRegenerateAccessKeyContent : IUtf8JsonSerializable, IJsonModel<EventHubsRegenerateAccessKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsRegenerateAccessKeyContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsRegenerateAccessKeyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsRegenerateAccessKeyContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        EventHubsRegenerateAccessKeyContent IJsonModel<EventHubsRegenerateAccessKeyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsRegenerateAccessKeyContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsRegenerateAccessKeyContent(document.RootElement, options);
        }

        internal static EventHubsRegenerateAccessKeyContent DeserializeEventHubsRegenerateAccessKeyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EventHubsAccessKeyType keyType = default;
            string key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = new EventHubsAccessKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubsRegenerateAccessKeyContent(keyType, key, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubsRegenerateAccessKeyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsRegenerateAccessKeyContent)} does not support '{options.Format}' format.");
            }
        }

        EventHubsRegenerateAccessKeyContent IPersistableModel<EventHubsRegenerateAccessKeyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsRegenerateAccessKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsRegenerateAccessKeyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsRegenerateAccessKeyContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsRegenerateAccessKeyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
