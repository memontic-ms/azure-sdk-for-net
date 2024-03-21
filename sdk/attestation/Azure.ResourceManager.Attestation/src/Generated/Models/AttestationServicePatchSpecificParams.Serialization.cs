// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    internal partial class AttestationServicePatchSpecificParams : IUtf8JsonSerializable, IJsonModel<AttestationServicePatchSpecificParams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AttestationServicePatchSpecificParams>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AttestationServicePatchSpecificParams>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServicePatchSpecificParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttestationServicePatchSpecificParams)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        AttestationServicePatchSpecificParams IJsonModel<AttestationServicePatchSpecificParams>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServicePatchSpecificParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttestationServicePatchSpecificParams)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttestationServicePatchSpecificParams(document.RootElement, options);
        }

        internal static AttestationServicePatchSpecificParams DeserializeAttestationServicePatchSpecificParams(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PublicNetworkAccessType? publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AttestationServicePatchSpecificParams(publicNetworkAccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AttestationServicePatchSpecificParams>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServicePatchSpecificParams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AttestationServicePatchSpecificParams)} does not support '{options.Format}' format.");
            }
        }

        AttestationServicePatchSpecificParams IPersistableModel<AttestationServicePatchSpecificParams>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServicePatchSpecificParams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAttestationServicePatchSpecificParams(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AttestationServicePatchSpecificParams)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AttestationServicePatchSpecificParams>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
