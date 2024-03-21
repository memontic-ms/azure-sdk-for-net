// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class NodeMonitoringData : IUtf8JsonSerializable, IJsonModel<NodeMonitoringData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeMonitoringData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeMonitoringData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeMonitoringData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(NodeName))
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableMemoryInMB))
            {
                writer.WritePropertyName("availableMemoryInMB"u8);
                writer.WriteNumberValue(AvailableMemoryInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuUtilization))
            {
                writer.WritePropertyName("cpuUtilization"u8);
                writer.WriteNumberValue(CpuUtilization.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsLimit))
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConcurrentJobsRunning))
            {
                writer.WritePropertyName("concurrentJobsRunning"u8);
                writer.WriteNumberValue(ConcurrentJobsRunning.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxConcurrentJobs))
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SentBytes))
            {
                writer.WritePropertyName("sentBytes"u8);
                writer.WriteNumberValue(SentBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReceivedBytes))
            {
                writer.WritePropertyName("receivedBytes"u8);
                writer.WriteNumberValue(ReceivedBytes.Value);
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

        NodeMonitoringData IJsonModel<NodeMonitoringData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeMonitoringData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeMonitoringData(document.RootElement, options);
        }

        internal static NodeMonitoringData DeserializeNodeMonitoringData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            string nodeName = default;
            int? availableMemoryInMB = default;
            int? cpuUtilization = default;
            int? concurrentJobsLimit = default;
            int? concurrentJobsRunning = default;
            int? maxConcurrentJobs = default;
            double? sentBytes = default;
            double? receivedBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    additionalProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUtilization = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsRunning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsRunning = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sentBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("receivedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receivedBytes = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeMonitoringData(
                additionalProperties ?? new ChangeTrackingDictionary<string, BinaryData>(),
                nodeName,
                availableMemoryInMB,
                cpuUtilization,
                concurrentJobsLimit,
                concurrentJobsRunning,
                maxConcurrentJobs,
                sentBytes,
                receivedBytes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeMonitoringData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeMonitoringData)} does not support '{options.Format}' format.");
            }
        }

        NodeMonitoringData IPersistableModel<NodeMonitoringData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeMonitoringData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeMonitoringData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeMonitoringData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeMonitoringData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
