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
    public partial class CategoryConfiguration : IUtf8JsonSerializable, IJsonModel<CategoryConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CategoryConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CategoryConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoryConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinimumSeverityLevel))
            {
                writer.WritePropertyName("minimumSeverityLevel"u8);
                writer.WriteStringValue(MinimumSeverityLevel);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
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

        CategoryConfiguration IJsonModel<CategoryConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoryConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCategoryConfiguration(document.RootElement, options);
        }

        internal static CategoryConfiguration DeserializeCategoryConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string minimumSeverityLevel = default;
            RuleCategory? category = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumSeverityLevel"u8))
                {
                    minimumSeverityLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new RuleCategory(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CategoryConfiguration(minimumSeverityLevel, category, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CategoryConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CategoryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CategoryConfiguration IPersistableModel<CategoryConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCategoryConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CategoryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CategoryConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
