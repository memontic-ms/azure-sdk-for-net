// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchLinuxUserConfiguration : IUtf8JsonSerializable, IJsonModel<BatchLinuxUserConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchLinuxUserConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchLinuxUserConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchLinuxUserConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchLinuxUserConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uid))
            {
                writer.WritePropertyName("uid"u8);
                writer.WriteNumberValue(Uid.Value);
            }
            if (Optional.IsDefined(Gid))
            {
                writer.WritePropertyName("gid"u8);
                writer.WriteNumberValue(Gid.Value);
            }
            if (Optional.IsDefined(SshPrivateKey))
            {
                writer.WritePropertyName("sshPrivateKey"u8);
                writer.WriteStringValue(SshPrivateKey);
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

        BatchLinuxUserConfiguration IJsonModel<BatchLinuxUserConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchLinuxUserConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchLinuxUserConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchLinuxUserConfiguration(document.RootElement, options);
        }

        internal static BatchLinuxUserConfiguration DeserializeBatchLinuxUserConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? uid = default;
            int? gid = default;
            string sshPrivateKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uid = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gid = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sshPrivateKey"u8))
                {
                    sshPrivateKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchLinuxUserConfiguration(uid, gid, sshPrivateKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchLinuxUserConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchLinuxUserConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchLinuxUserConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchLinuxUserConfiguration IPersistableModel<BatchLinuxUserConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchLinuxUserConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchLinuxUserConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchLinuxUserConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchLinuxUserConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
