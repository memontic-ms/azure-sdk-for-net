// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class TimeWindowCustomAlertRule : IUtf8JsonSerializable, IJsonModel<TimeWindowCustomAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TimeWindowCustomAlertRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TimeWindowCustomAlertRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeWindowCustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimeWindowCustomAlertRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("timeWindowSize"u8);
            writer.WriteStringValue(TimeWindowSize, "P");
            writer.WritePropertyName("minThreshold"u8);
            writer.WriteNumberValue(MinThreshold);
            writer.WritePropertyName("maxThreshold"u8);
            writer.WriteNumberValue(MaxThreshold);
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        TimeWindowCustomAlertRule IJsonModel<TimeWindowCustomAlertRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeWindowCustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimeWindowCustomAlertRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeWindowCustomAlertRule(document.RootElement, options);
        }

        internal static TimeWindowCustomAlertRule DeserializeTimeWindowCustomAlertRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ActiveConnectionsNotInAllowedRange": return ActiveConnectionsNotInAllowedRange.DeserializeActiveConnectionsNotInAllowedRange(element, options);
                    case "AmqpC2DMessagesNotInAllowedRange": return AmqpC2DMessagesNotInAllowedRange.DeserializeAmqpC2DMessagesNotInAllowedRange(element, options);
                    case "AmqpC2DRejectedMessagesNotInAllowedRange": return AmqpC2DRejectedMessagesNotInAllowedRange.DeserializeAmqpC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "AmqpD2CMessagesNotInAllowedRange": return AmqpD2CMessagesNotInAllowedRange.DeserializeAmqpD2CMessagesNotInAllowedRange(element, options);
                    case "DirectMethodInvokesNotInAllowedRange": return DirectMethodInvokesNotInAllowedRange.DeserializeDirectMethodInvokesNotInAllowedRange(element, options);
                    case "FailedLocalLoginsNotInAllowedRange": return FailedLocalLoginsNotInAllowedRange.DeserializeFailedLocalLoginsNotInAllowedRange(element, options);
                    case "FileUploadsNotInAllowedRange": return FileUploadsNotInAllowedRange.DeserializeFileUploadsNotInAllowedRange(element, options);
                    case "HttpC2DMessagesNotInAllowedRange": return HttpC2DMessagesNotInAllowedRange.DeserializeHttpC2DMessagesNotInAllowedRange(element, options);
                    case "HttpC2DRejectedMessagesNotInAllowedRange": return HttpC2DRejectedMessagesNotInAllowedRange.DeserializeHttpC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "HttpD2CMessagesNotInAllowedRange": return HttpD2CMessagesNotInAllowedRange.DeserializeHttpD2CMessagesNotInAllowedRange(element, options);
                    case "MqttC2DMessagesNotInAllowedRange": return MqttC2DMessagesNotInAllowedRange.DeserializeMqttC2DMessagesNotInAllowedRange(element, options);
                    case "MqttC2DRejectedMessagesNotInAllowedRange": return MqttC2DRejectedMessagesNotInAllowedRange.DeserializeMqttC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "MqttD2CMessagesNotInAllowedRange": return MqttD2CMessagesNotInAllowedRange.DeserializeMqttD2CMessagesNotInAllowedRange(element, options);
                    case "QueuePurgesNotInAllowedRange": return QueuePurgesNotInAllowedRange.DeserializeQueuePurgesNotInAllowedRange(element, options);
                    case "TwinUpdatesNotInAllowedRange": return TwinUpdatesNotInAllowedRange.DeserializeTwinUpdatesNotInAllowedRange(element, options);
                    case "UnauthorizedOperationsNotInAllowedRange": return UnauthorizedOperationsNotInAllowedRange.DeserializeUnauthorizedOperationsNotInAllowedRange(element, options);
                }
            }
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            string displayName = default;
            string description = default;
            bool isEnabled = default;
            string ruleType = "TimeWindowCustomAlertRule";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"u8))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"u8))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"u8))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TimeWindowCustomAlertRule(
                displayName,
                description,
                isEnabled,
                ruleType,
                serializedAdditionalRawData,
                minThreshold,
                maxThreshold,
                timeWindowSize);
        }

        BinaryData IPersistableModel<TimeWindowCustomAlertRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeWindowCustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TimeWindowCustomAlertRule)} does not support '{options.Format}' format.");
            }
        }

        TimeWindowCustomAlertRule IPersistableModel<TimeWindowCustomAlertRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimeWindowCustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTimeWindowCustomAlertRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TimeWindowCustomAlertRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TimeWindowCustomAlertRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
