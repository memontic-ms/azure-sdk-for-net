// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class AzureStorageBlobContainerEndpointProperties : IUtf8JsonSerializable, IJsonModel<AzureStorageBlobContainerEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureStorageBlobContainerEndpointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureStorageBlobContainerEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageBlobContainerEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountResourceId"u8);
            writer.WriteStringValue(StorageAccountResourceId);
            writer.WritePropertyName("blobContainerName"u8);
            writer.WriteStringValue(BlobContainerName);
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AzureStorageBlobContainerEndpointProperties IJsonModel<AzureStorageBlobContainerEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageBlobContainerEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureStorageBlobContainerEndpointProperties(document.RootElement, options);
        }

        internal static AzureStorageBlobContainerEndpointProperties DeserializeAzureStorageBlobContainerEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccountResourceId = default;
            string blobContainerName = default;
            EndpointType endpointType = default;
            string description = default;
            StorageMoverProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountResourceId"u8))
                {
                    storageAccountResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobContainerName"u8))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StorageMoverProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureStorageBlobContainerEndpointProperties(
                endpointType,
                description,
                provisioningState,
                serializedAdditionalRawData,
                storageAccountResourceId,
                blobContainerName);
        }

        BinaryData IPersistableModel<AzureStorageBlobContainerEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageBlobContainerEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        AzureStorageBlobContainerEndpointProperties IPersistableModel<AzureStorageBlobContainerEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageBlobContainerEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureStorageBlobContainerEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureStorageBlobContainerEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureStorageBlobContainerEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
