// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSweepJobLimits : IUtf8JsonSerializable, IJsonModel<MachineLearningSweepJobLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSweepJobLimits>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSweepJobLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                if (MaxConcurrentTrials != null)
                {
                    writer.WritePropertyName("maxConcurrentTrials"u8);
                    writer.WriteNumberValue(MaxConcurrentTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxConcurrentTrials");
                }
            }
            if (Optional.IsDefined(MaxTotalTrials))
            {
                if (MaxTotalTrials != null)
                {
                    writer.WritePropertyName("maxTotalTrials"u8);
                    writer.WriteNumberValue(MaxTotalTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxTotalTrials");
                }
            }
            if (Optional.IsDefined(TrialTimeout))
            {
                if (TrialTimeout != null)
                {
                    writer.WritePropertyName("trialTimeout"u8);
                    writer.WriteStringValue(TrialTimeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("trialTimeout");
                }
            }
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
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

        MachineLearningSweepJobLimits IJsonModel<MachineLearningSweepJobLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSweepJobLimits(document.RootElement, options);
        }

        internal static MachineLearningSweepJobLimits DeserializeMachineLearningSweepJobLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxConcurrentTrials = default;
            int? maxTotalTrials = default;
            TimeSpan? trialTimeout = default;
            JobLimitsType jobLimitsType = default;
            TimeSpan? timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxConcurrentTrials = null;
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxTotalTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxTotalTrials = null;
                        continue;
                    }
                    maxTotalTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trialTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trialTimeout = null;
                        continue;
                    }
                    trialTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("jobLimitsType"u8))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSweepJobLimits(
                jobLimitsType,
                timeout,
                serializedAdditionalRawData,
                maxConcurrentTrials,
                maxTotalTrials,
                trialTimeout);
        }

        BinaryData IPersistableModel<MachineLearningSweepJobLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningSweepJobLimits IPersistableModel<MachineLearningSweepJobLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSweepJobLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSweepJobLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
