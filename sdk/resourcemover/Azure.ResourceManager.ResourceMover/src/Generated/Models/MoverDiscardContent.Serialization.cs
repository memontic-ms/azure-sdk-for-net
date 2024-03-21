// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverDiscardContent : IUtf8JsonSerializable, IJsonModel<MoverDiscardContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverDiscardContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverDiscardContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverDiscardContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverDiscardContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateOnly))
            {
                writer.WritePropertyName("validateOnly"u8);
                writer.WriteBooleanValue(ValidateOnly.Value);
            }
            writer.WritePropertyName("moveResources"u8);
            writer.WriteStartArray();
            foreach (var item in MoverResources)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MoverResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType"u8);
                writer.WriteStringValue(MoverResourceInputType.Value.ToString());
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

        MoverDiscardContent IJsonModel<MoverDiscardContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverDiscardContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverDiscardContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverDiscardContent(document.RootElement, options);
        }

        internal static MoverDiscardContent DeserializeMoverDiscardContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? validateOnly = default;
            IList<ResourceIdentifier> moveResources = default;
            MoverResourceInputType? moveResourceInputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("moveResources"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    moveResources = array;
                    continue;
                }
                if (property.NameEquals("moveResourceInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveResourceInputType = new MoverResourceInputType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverDiscardContent(validateOnly, moveResources, moveResourceInputType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverDiscardContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverDiscardContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverDiscardContent)} does not support '{options.Format}' format.");
            }
        }

        MoverDiscardContent IPersistableModel<MoverDiscardContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverDiscardContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverDiscardContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverDiscardContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverDiscardContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
