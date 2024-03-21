// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveSummary : IUtf8JsonSerializable, IJsonModel<CveSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CveSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CveSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Critical))
            {
                if (Critical != null)
                {
                    writer.WritePropertyName("critical"u8);
                    writer.WriteNumberValue(Critical.Value);
                }
                else
                {
                    writer.WriteNull("critical");
                }
            }
            if (Optional.IsDefined(High))
            {
                if (High != null)
                {
                    writer.WritePropertyName("high"u8);
                    writer.WriteNumberValue(High.Value);
                }
                else
                {
                    writer.WriteNull("high");
                }
            }
            if (Optional.IsDefined(Medium))
            {
                if (Medium != null)
                {
                    writer.WritePropertyName("medium"u8);
                    writer.WriteNumberValue(Medium.Value);
                }
                else
                {
                    writer.WriteNull("medium");
                }
            }
            if (Optional.IsDefined(Low))
            {
                if (Low != null)
                {
                    writer.WritePropertyName("low"u8);
                    writer.WriteNumberValue(Low.Value);
                }
                else
                {
                    writer.WriteNull("low");
                }
            }
            if (Optional.IsDefined(Unknown))
            {
                if (Unknown != null)
                {
                    writer.WritePropertyName("unknown"u8);
                    writer.WriteNumberValue(Unknown.Value);
                }
                else
                {
                    writer.WriteNull("unknown");
                }
            }
            writer.WritePropertyName("summaryType"u8);
            writer.WriteStringValue(SummaryType.ToString());
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

        CveSummary IJsonModel<CveSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCveSummary(document.RootElement, options);
        }

        internal static CveSummary DeserializeCveSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? critical = default;
            long? high = default;
            long? medium = default;
            long? low = default;
            long? unknown = default;
            FirmwareAnalysisSummaryType summaryType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("critical"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        critical = null;
                        continue;
                    }
                    critical = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        high = null;
                        continue;
                    }
                    high = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("medium"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        medium = null;
                        continue;
                    }
                    medium = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        low = null;
                        continue;
                    }
                    low = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        unknown = null;
                        continue;
                    }
                    unknown = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("summaryType"u8))
                {
                    summaryType = new FirmwareAnalysisSummaryType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CveSummary(
                summaryType,
                serializedAdditionalRawData,
                critical,
                high,
                medium,
                low,
                unknown);
        }

        BinaryData IPersistableModel<CveSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CveSummary)} does not support '{options.Format}' format.");
            }
        }

        CveSummary IPersistableModel<CveSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCveSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CveSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CveSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
