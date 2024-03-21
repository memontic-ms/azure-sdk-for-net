// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class TrunkedNetworkAttachmentConfiguration : IUtf8JsonSerializable, IJsonModel<TrunkedNetworkAttachmentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrunkedNetworkAttachmentConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrunkedNetworkAttachmentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrunkedNetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrunkedNetworkAttachmentConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsDefined(PluginType))
            {
                writer.WritePropertyName("pluginType"u8);
                writer.WriteStringValue(PluginType.Value.ToString());
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

        TrunkedNetworkAttachmentConfiguration IJsonModel<TrunkedNetworkAttachmentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrunkedNetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrunkedNetworkAttachmentConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrunkedNetworkAttachmentConfiguration(document.RootElement, options);
        }

        internal static TrunkedNetworkAttachmentConfiguration DeserializeTrunkedNetworkAttachmentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkId = default;
            KubernetesPluginType? pluginType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pluginType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginType = new KubernetesPluginType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrunkedNetworkAttachmentConfiguration(networkId, pluginType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrunkedNetworkAttachmentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrunkedNetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrunkedNetworkAttachmentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        TrunkedNetworkAttachmentConfiguration IPersistableModel<TrunkedNetworkAttachmentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrunkedNetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrunkedNetworkAttachmentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrunkedNetworkAttachmentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrunkedNetworkAttachmentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
