// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityCheckResult : IUtf8JsonSerializable, IJsonModel<ConnectivityCheckResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityCheckResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectivityCheckResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Hops))
            {
                writer.WritePropertyName("hops"u8);
                writer.WriteStartArray();
                foreach (var item in Hops)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AvgLatencyInMs))
            {
                writer.WritePropertyName("avgLatencyInMs"u8);
                writer.WriteNumberValue(AvgLatencyInMs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinLatencyInMs))
            {
                writer.WritePropertyName("minLatencyInMs"u8);
                writer.WriteNumberValue(MinLatencyInMs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxLatencyInMs))
            {
                writer.WritePropertyName("maxLatencyInMs"u8);
                writer.WriteNumberValue(MaxLatencyInMs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProbesSent))
            {
                writer.WritePropertyName("probesSent"u8);
                writer.WriteNumberValue(ProbesSent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProbesFailed))
            {
                writer.WritePropertyName("probesFailed"u8);
                writer.WriteNumberValue(ProbesFailed.Value);
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

        ConnectivityCheckResult IJsonModel<ConnectivityCheckResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityCheckResult(document.RootElement, options);
        }

        internal static ConnectivityCheckResult DeserializeConnectivityCheckResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ConnectivityHop> hops = default;
            ConnectionStatus? connectionStatus = default;
            long? avgLatencyInMs = default;
            long? minLatencyInMs = default;
            long? maxLatencyInMs = default;
            long? probesSent = default;
            long? probesFailed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityHop> array = new List<ConnectivityHop>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityHop.DeserializeConnectivityHop(item, options));
                    }
                    hops = array;
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new ConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("probesSent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("probesFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesFailed = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectivityCheckResult(
                hops ?? new ChangeTrackingList<ConnectivityHop>(),
                connectionStatus,
                avgLatencyInMs,
                minLatencyInMs,
                maxLatencyInMs,
                probesSent,
                probesFailed,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityCheckResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckResult)} does not support '{options.Format}' format.");
            }
        }

        ConnectivityCheckResult IPersistableModel<ConnectivityCheckResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectivityCheckResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityCheckResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
