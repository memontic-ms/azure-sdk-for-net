// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class FailoverGroupReadOnlyEndpoint : IUtf8JsonSerializable, IJsonModel<FailoverGroupReadOnlyEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverGroupReadOnlyEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FailoverGroupReadOnlyEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupReadOnlyEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailoverPolicy))
            {
                writer.WritePropertyName("failoverPolicy"u8);
                writer.WriteStringValue(FailoverPolicy.Value.ToString());
            }
            if (Optional.IsDefined(TargetServer))
            {
                writer.WritePropertyName("targetServer"u8);
                writer.WriteStringValue(TargetServer);
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

        FailoverGroupReadOnlyEndpoint IJsonModel<FailoverGroupReadOnlyEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupReadOnlyEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverGroupReadOnlyEndpoint(document.RootElement, options);
        }

        internal static FailoverGroupReadOnlyEndpoint DeserializeFailoverGroupReadOnlyEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReadOnlyEndpointFailoverPolicy? failoverPolicy = default;
            ResourceIdentifier targetServer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverPolicy = new ReadOnlyEndpointFailoverPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetServer = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FailoverGroupReadOnlyEndpoint(failoverPolicy, targetServer, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FailoverGroupReadOnlyEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupReadOnlyEndpoint)} does not support '{options.Format}' format.");
            }
        }

        FailoverGroupReadOnlyEndpoint IPersistableModel<FailoverGroupReadOnlyEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverGroupReadOnlyEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupReadOnlyEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverGroupReadOnlyEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
