// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    public partial class TargetResourceEndpointAccess : IUtf8JsonSerializable, IJsonModel<TargetResourceEndpointAccess>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetResourceEndpointAccess>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TargetResourceEndpointAccess>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetResourceEndpointAccess>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("relay"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Optional.IsDefined(NamespaceNameSuffix))
            {
                writer.WritePropertyName("namespaceNameSuffix"u8);
                writer.WriteStringValue(NamespaceNameSuffix);
            }
            if (Optional.IsDefined(HybridConnectionName))
            {
                writer.WritePropertyName("hybridConnectionName"u8);
                writer.WriteStringValue(HybridConnectionName);
            }
            if (options.Format != "W" && Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expiresOn"u8);
                writer.WriteNumberValue(ExpiresOn.Value);
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

        TargetResourceEndpointAccess IJsonModel<TargetResourceEndpointAccess>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetResourceEndpointAccess>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetResourceEndpointAccess(document.RootElement, options);
        }

        internal static TargetResourceEndpointAccess DeserializeTargetResourceEndpointAccess(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string namespaceName = default;
            string namespaceNameSuffix = default;
            string hybridConnectionName = default;
            string accessKey = default;
            long? expiresOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("namespaceName"u8))
                        {
                            namespaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("namespaceNameSuffix"u8))
                        {
                            namespaceNameSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hybridConnectionName"u8))
                        {
                            hybridConnectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessKey"u8))
                        {
                            accessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expiresOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiresOn = property0.Value.GetInt64();
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
            return new TargetResourceEndpointAccess(
                namespaceName,
                namespaceNameSuffix,
                hybridConnectionName,
                accessKey,
                expiresOn,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetResourceEndpointAccess>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetResourceEndpointAccess>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{options.Format}' format.");
            }
        }

        TargetResourceEndpointAccess IPersistableModel<TargetResourceEndpointAccess>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetResourceEndpointAccess>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTargetResourceEndpointAccess(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetResourceEndpointAccess)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetResourceEndpointAccess>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
