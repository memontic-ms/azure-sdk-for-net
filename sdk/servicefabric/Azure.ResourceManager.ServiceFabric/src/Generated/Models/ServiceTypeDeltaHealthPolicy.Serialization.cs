// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceTypeDeltaHealthPolicy : IUtf8JsonSerializable, IJsonModel<ServiceTypeDeltaHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceTypeDeltaHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceTypeDeltaHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTypeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceTypeDeltaHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPercentDeltaUnhealthyServices))
            {
                writer.WritePropertyName("maxPercentDeltaUnhealthyServices"u8);
                writer.WriteNumberValue(MaxPercentDeltaUnhealthyServices.Value);
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

        ServiceTypeDeltaHealthPolicy IJsonModel<ServiceTypeDeltaHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTypeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceTypeDeltaHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceTypeDeltaHealthPolicy(document.RootElement, options);
        }

        internal static ServiceTypeDeltaHealthPolicy DeserializeServiceTypeDeltaHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxPercentDeltaUnhealthyServices = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentDeltaUnhealthyServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentDeltaUnhealthyServices = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceTypeDeltaHealthPolicy(maxPercentDeltaUnhealthyServices, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceTypeDeltaHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTypeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceTypeDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ServiceTypeDeltaHealthPolicy IPersistableModel<ServiceTypeDeltaHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTypeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceTypeDeltaHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceTypeDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceTypeDeltaHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
