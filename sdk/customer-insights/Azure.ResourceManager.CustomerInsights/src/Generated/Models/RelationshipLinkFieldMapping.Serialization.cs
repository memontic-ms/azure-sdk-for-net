// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class RelationshipLinkFieldMapping : IUtf8JsonSerializable, IJsonModel<RelationshipLinkFieldMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RelationshipLinkFieldMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RelationshipLinkFieldMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkFieldMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkFieldMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("interactionFieldName"u8);
            writer.WriteStringValue(InteractionFieldName);
            if (Optional.IsDefined(LinkType))
            {
                writer.WritePropertyName("linkType"u8);
                writer.WriteStringValue(LinkType.Value.ToSerialString());
            }
            writer.WritePropertyName("relationshipFieldName"u8);
            writer.WriteStringValue(RelationshipFieldName);
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

        RelationshipLinkFieldMapping IJsonModel<RelationshipLinkFieldMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkFieldMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkFieldMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRelationshipLinkFieldMapping(document.RootElement, options);
        }

        internal static RelationshipLinkFieldMapping DeserializeRelationshipLinkFieldMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string interactionFieldName = default;
            LinkType? linkType = default;
            string relationshipFieldName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interactionFieldName"u8))
                {
                    interactionFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkType = property.Value.GetString().ToLinkType();
                    continue;
                }
                if (property.NameEquals("relationshipFieldName"u8))
                {
                    relationshipFieldName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RelationshipLinkFieldMapping(interactionFieldName, linkType, relationshipFieldName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RelationshipLinkFieldMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkFieldMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkFieldMapping)} does not support '{options.Format}' format.");
            }
        }

        RelationshipLinkFieldMapping IPersistableModel<RelationshipLinkFieldMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkFieldMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRelationshipLinkFieldMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkFieldMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RelationshipLinkFieldMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
