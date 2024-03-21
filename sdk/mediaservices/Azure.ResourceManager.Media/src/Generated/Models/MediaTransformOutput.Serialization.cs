// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaTransformOutput : IUtf8JsonSerializable, IJsonModel<MediaTransformOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaTransformOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaTransformOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTransformOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaTransformOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OnError))
            {
                writer.WritePropertyName("onError"u8);
                writer.WriteStringValue(OnError.Value.ToString());
            }
            if (Optional.IsDefined(RelativePriority))
            {
                writer.WritePropertyName("relativePriority"u8);
                writer.WriteStringValue(RelativePriority.Value.ToString());
            }
            writer.WritePropertyName("preset"u8);
            writer.WriteObjectValue(Preset);
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

        MediaTransformOutput IJsonModel<MediaTransformOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTransformOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaTransformOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaTransformOutput(document.RootElement, options);
        }

        internal static MediaTransformOutput DeserializeMediaTransformOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MediaTransformOnErrorType? onError = default;
            MediaJobPriority? relativePriority = default;
            MediaTransformPreset preset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("onError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onError = new MediaTransformOnErrorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("relativePriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativePriority = new MediaJobPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preset"u8))
                {
                    preset = MediaTransformPreset.DeserializeMediaTransformPreset(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaTransformOutput(onError, relativePriority, preset, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaTransformOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTransformOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaTransformOutput)} does not support '{options.Format}' format.");
            }
        }

        MediaTransformOutput IPersistableModel<MediaTransformOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaTransformOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaTransformOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaTransformOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaTransformOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
