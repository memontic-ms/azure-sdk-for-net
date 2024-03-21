// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityLogRules : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityLogRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityLogRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRelicObservabilityLogRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
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

        NewRelicObservabilityLogRules IJsonModel<NewRelicObservabilityLogRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
        }

        internal static NewRelicObservabilityLogRules DeserializeNewRelicObservabilityLogRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NewRelicObservabilitySendAadLogsStatus? sendAadLogs = default;
            NewRelicObservabilitySendSubscriptionLogsStatus? sendSubscriptionLogs = default;
            NewRelicObservabilitySendActivityLogsStatus? sendActivityLogs = default;
            IList<NewRelicObservabilityFilteringTag> filteringTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = new NewRelicObservabilitySendAadLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = new NewRelicObservabilitySendSubscriptionLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = new NewRelicObservabilitySendActivityLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicObservabilityFilteringTag> array = new List<NewRelicObservabilityFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicObservabilityFilteringTag.DeserializeNewRelicObservabilityFilteringTag(item, options));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicObservabilityLogRules(sendAadLogs, sendSubscriptionLogs, sendActivityLogs, filteringTags ?? new ChangeTrackingList<NewRelicObservabilityFilteringTag>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicObservabilityLogRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{options.Format}' format.");
            }
        }

        NewRelicObservabilityLogRules IPersistableModel<NewRelicObservabilityLogRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityLogRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
