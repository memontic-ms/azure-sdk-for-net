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
    public partial class BatchAccountEndpointDependency : IUtf8JsonSerializable, IJsonModel<BatchAccountEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountEndpointDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountEndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountEndpointDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BatchAccountEndpointDependency IJsonModel<BatchAccountEndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountEndpointDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountEndpointDependency(document.RootElement, options);
        }

        internal static BatchAccountEndpointDependency DeserializeBatchAccountEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            string description = default;
            IReadOnlyList<BatchEndpointDetail> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchEndpointDetail> array = new List<BatchEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchEndpointDetail.DeserializeBatchEndpointDetail(item, options));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountEndpointDependency(domainName, description, endpointDetails ?? new ChangeTrackingList<BatchEndpointDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountEndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountEndpointDependency IPersistableModel<BatchAccountEndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountEndpointDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountEndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
