// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeWindowsConfiguration : IUtf8JsonSerializable, IJsonModel<HybridComputeWindowsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeWindowsConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeWindowsConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeWindowsConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("patchSettings"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        HybridComputeWindowsConfiguration IJsonModel<HybridComputeWindowsConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeWindowsConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeWindowsConfiguration(document.RootElement, options);
        }

        internal static HybridComputeWindowsConfiguration DeserializeHybridComputeWindowsConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssessmentModeType? assessmentMode = default;
            PatchModeType? patchMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assessmentMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentMode = new AssessmentModeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("patchMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            patchMode = new PatchModeType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeWindowsConfiguration(assessmentMode, patchMode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeWindowsConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeWindowsConfiguration)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeWindowsConfiguration IPersistableModel<HybridComputeWindowsConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeWindowsConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeWindowsConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeWindowsConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
