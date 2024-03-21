// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WorkbookTemplateLocalizedGallery : IUtf8JsonSerializable, IJsonModel<WorkbookTemplateLocalizedGallery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkbookTemplateLocalizedGallery>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkbookTemplateLocalizedGallery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplateLocalizedGallery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateData))
            {
                writer.WritePropertyName("templateData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TemplateData);
#else
                using (JsonDocument document = JsonDocument.Parse(TemplateData))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Galleries))
            {
                writer.WritePropertyName("galleries"u8);
                writer.WriteStartArray();
                foreach (var item in Galleries)
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

        WorkbookTemplateLocalizedGallery IJsonModel<WorkbookTemplateLocalizedGallery>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplateLocalizedGallery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkbookTemplateLocalizedGallery(document.RootElement, options);
        }

        internal static WorkbookTemplateLocalizedGallery DeserializeWorkbookTemplateLocalizedGallery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData templateData = default;
            IList<WorkbookTemplateGallery> galleries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateData = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("galleries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkbookTemplateGallery> array = new List<WorkbookTemplateGallery>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkbookTemplateGallery.DeserializeWorkbookTemplateGallery(item, options));
                    }
                    galleries = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkbookTemplateLocalizedGallery(templateData, galleries ?? new ChangeTrackingList<WorkbookTemplateGallery>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkbookTemplateLocalizedGallery>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplateLocalizedGallery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{options.Format}' format.");
            }
        }

        WorkbookTemplateLocalizedGallery IPersistableModel<WorkbookTemplateLocalizedGallery>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookTemplateLocalizedGallery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkbookTemplateLocalizedGallery(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkbookTemplateLocalizedGallery)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkbookTemplateLocalizedGallery>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
