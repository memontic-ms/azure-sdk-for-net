// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class GalleryImageVersion : IUtf8JsonSerializable, IJsonModel<GalleryImageVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryImageVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            writer.WriteEndObject();
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

        GalleryImageVersion IJsonModel<GalleryImageVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersion(document.RootElement, options);
        }

        internal static GalleryImageVersion DeserializeGalleryImageVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            GalleryImageVersionStorageProfile storageProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = GalleryImageVersionStorageProfile.DeserializeGalleryImageVersionStorageProfile(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryImageVersion(name, storageProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryImageVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersion)} does not support '{options.Format}' format.");
            }
        }

        GalleryImageVersion IPersistableModel<GalleryImageVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryImageVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
