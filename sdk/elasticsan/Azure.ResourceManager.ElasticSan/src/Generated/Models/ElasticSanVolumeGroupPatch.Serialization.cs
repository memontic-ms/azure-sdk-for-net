// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVolumeGroupPatch : IUtf8JsonSerializable, IJsonModel<ElasticSanVolumeGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticSanVolumeGroupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticSanVolumeGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolType))
            {
                writer.WritePropertyName("protocolType"u8);
                writer.WriteStringValue(ProtocolType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteStringValue(Encryption.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionProperties))
            {
                writer.WritePropertyName("encryptionProperties"u8);
                writer.WriteObjectValue(EncryptionProperties);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkAcls);
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

        ElasticSanVolumeGroupPatch IJsonModel<ElasticSanVolumeGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanVolumeGroupPatch(document.RootElement, options);
        }

        internal static ElasticSanVolumeGroupPatch DeserializeElasticSanVolumeGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            ElasticSanStorageTargetType? protocolType = default;
            ElasticSanEncryptionType? encryption = default;
            ElasticSanEncryptionProperties encryptionProperties = default;
            NetworkRuleSet networkAcls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("protocolType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocolType = new ElasticSanStorageTargetType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = new ElasticSanEncryptionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProperties = ElasticSanEncryptionProperties.DeserializeElasticSanEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value, options);
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
            return new ElasticSanVolumeGroupPatch(
                identity,
                protocolType,
                encryption,
                encryptionProperties,
                networkAcls,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticSanVolumeGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        ElasticSanVolumeGroupPatch IPersistableModel<ElasticSanVolumeGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticSanVolumeGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticSanVolumeGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
