// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleSchedulePolicyV2 : IUtf8JsonSerializable, IJsonModel<SimpleSchedulePolicyV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimpleSchedulePolicyV2>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SimpleSchedulePolicyV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency"u8);
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule);
            }
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule);
            }
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
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

        SimpleSchedulePolicyV2 IJsonModel<SimpleSchedulePolicyV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
        }

        internal static SimpleSchedulePolicyV2 DeserializeSimpleSchedulePolicyV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleRunType? scheduleRunFrequency = default;
            BackupHourlySchedule hourlySchedule = default;
            BackupDailySchedule dailySchedule = default;
            BackupWeeklySchedule weeklySchedule = default;
            string schedulePolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourlySchedule = BackupHourlySchedule.DeserializeBackupHourlySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailySchedule = BackupDailySchedule.DeserializeBackupDailySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklySchedule = BackupWeeklySchedule.DeserializeBackupWeeklySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SimpleSchedulePolicyV2(
                schedulePolicyType,
                serializedAdditionalRawData,
                scheduleRunFrequency,
                hourlySchedule,
                dailySchedule,
                weeklySchedule);
        }

        BinaryData IPersistableModel<SimpleSchedulePolicyV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{options.Format}' format.");
            }
        }

        SimpleSchedulePolicyV2 IPersistableModel<SimpleSchedulePolicyV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimpleSchedulePolicyV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
