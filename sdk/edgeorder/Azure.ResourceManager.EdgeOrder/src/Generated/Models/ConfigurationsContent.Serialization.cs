// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ConfigurationsContent : IUtf8JsonSerializable, IJsonModel<ConfigurationsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationsContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationsContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("configurationFilters"u8);
            writer.WriteStartArray();
            foreach (var item in ConfigurationFilters)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(CustomerSubscriptionDetails))
            {
                writer.WritePropertyName("customerSubscriptionDetails"u8);
                writer.WriteObjectValue(CustomerSubscriptionDetails);
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

        ConfigurationsContent IJsonModel<ConfigurationsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationsContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationsContent(document.RootElement, options);
        }

        internal static ConfigurationsContent DeserializeConfigurationsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ConfigurationFilters> configurationFilters = default;
            CustomerSubscriptionDetails customerSubscriptionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationFilters"u8))
                {
                    List<ConfigurationFilters> array = new List<ConfigurationFilters>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ConfigurationFilters.DeserializeConfigurationFilters(item, options));
                    }
                    configurationFilters = array;
                    continue;
                }
                if (property.NameEquals("customerSubscriptionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerSubscriptionDetails = CustomerSubscriptionDetails.DeserializeCustomerSubscriptionDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigurationsContent(configurationFilters, customerSubscriptionDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationsContent)} does not support '{options.Format}' format.");
            }
        }

        ConfigurationsContent IPersistableModel<ConfigurationsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationsContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
