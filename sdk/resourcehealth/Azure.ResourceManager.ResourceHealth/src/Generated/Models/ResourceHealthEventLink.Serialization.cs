// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventLink : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventLink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthEventLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventLink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LinkType.Value.ToString());
            }
            if (Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText"u8);
                writer.WriteObjectValue(DisplayText);
            }
            if (Optional.IsDefined(ExtensionName))
            {
                writer.WritePropertyName("extensionName"u8);
                writer.WriteStringValue(ExtensionName);
            }
            if (Optional.IsDefined(BladeName))
            {
                writer.WritePropertyName("bladeName"u8);
                writer.WriteStringValue(BladeName);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ResourceHealthEventLink IJsonModel<ResourceHealthEventLink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventLink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventLink(document.RootElement, options);
        }

        internal static ResourceHealthEventLink DeserializeResourceHealthEventLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceHealthEventLinkTypeValue? type = default;
            ResourceHealthEventLinkDisplayText displayText = default;
            string extensionName = default;
            string bladeName = default;
            BinaryData parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceHealthEventLinkTypeValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayText"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayText = ResourceHealthEventLinkDisplayText.DeserializeResourceHealthEventLinkDisplayText(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extensionName"u8))
                {
                    extensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bladeName"u8))
                {
                    bladeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthEventLink(
                type,
                displayText,
                extensionName,
                bladeName,
                parameters,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthEventLink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventLink)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthEventLink IPersistableModel<ResourceHealthEventLink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventLink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventLink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventLink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
