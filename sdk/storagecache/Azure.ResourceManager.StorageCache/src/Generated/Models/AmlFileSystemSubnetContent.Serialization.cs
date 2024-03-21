// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemSubnetContent : IUtf8JsonSerializable, IJsonModel<AmlFileSystemSubnetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemSubnetContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlFileSystemSubnetContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemSubnetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemSubnetContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FilesystemSubnet))
            {
                writer.WritePropertyName("filesystemSubnet"u8);
                writer.WriteStringValue(FilesystemSubnet);
            }
            if (Optional.IsDefined(StorageCapacityTiB))
            {
                writer.WritePropertyName("storageCapacityTiB"u8);
                writer.WriteNumberValue(StorageCapacityTiB.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        AmlFileSystemSubnetContent IJsonModel<AmlFileSystemSubnetContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemSubnetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemSubnetContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemSubnetContent(document.RootElement, options);
        }

        internal static AmlFileSystemSubnetContent DeserializeAmlFileSystemSubnetContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filesystemSubnet = default;
            float? storageCapacityTiB = default;
            StorageCacheSkuName sku = default;
            AzureLocation? location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filesystemSubnet"u8))
                {
                    filesystemSubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageCapacityTiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageCapacityTiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuName.DeserializeStorageCacheSkuName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemSubnetContent(filesystemSubnet, storageCapacityTiB, sku, location, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemSubnetContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemSubnetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemSubnetContent)} does not support '{options.Format}' format.");
            }
        }

        AmlFileSystemSubnetContent IPersistableModel<AmlFileSystemSubnetContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemSubnetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemSubnetContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemSubnetContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemSubnetContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
