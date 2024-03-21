// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RulesEngineAction : IUtf8JsonSerializable, IJsonModel<RulesEngineAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RulesEngineAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RulesEngineAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulesEngineAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RequestHeaderActions))
            {
                writer.WritePropertyName("requestHeaderActions"u8);
                writer.WriteStartArray();
                foreach (var item in RequestHeaderActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResponseHeaderActions))
            {
                writer.WritePropertyName("responseHeaderActions"u8);
                writer.WriteStartArray();
                foreach (var item in ResponseHeaderActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RouteConfigurationOverride))
            {
                if (RouteConfigurationOverride != null)
                {
                    writer.WritePropertyName("routeConfigurationOverride"u8);
                    writer.WriteObjectValue(RouteConfigurationOverride);
                }
                else
                {
                    writer.WriteNull("routeConfigurationOverride");
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

        RulesEngineAction IJsonModel<RulesEngineAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulesEngineAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRulesEngineAction(document.RootElement, options);
        }

        internal static RulesEngineAction DeserializeRulesEngineAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RulesEngineHeaderAction> requestHeaderActions = default;
            IList<RulesEngineHeaderAction> responseHeaderActions = default;
            RouteConfiguration routeConfigurationOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestHeaderActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineHeaderAction> array = new List<RulesEngineHeaderAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineHeaderAction.DeserializeRulesEngineHeaderAction(item, options));
                    }
                    requestHeaderActions = array;
                    continue;
                }
                if (property.NameEquals("responseHeaderActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineHeaderAction> array = new List<RulesEngineHeaderAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineHeaderAction.DeserializeRulesEngineHeaderAction(item, options));
                    }
                    responseHeaderActions = array;
                    continue;
                }
                if (property.NameEquals("routeConfigurationOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        routeConfigurationOverride = null;
                        continue;
                    }
                    routeConfigurationOverride = RouteConfiguration.DeserializeRouteConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RulesEngineAction(requestHeaderActions ?? new ChangeTrackingList<RulesEngineHeaderAction>(), responseHeaderActions ?? new ChangeTrackingList<RulesEngineHeaderAction>(), routeConfigurationOverride, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RulesEngineAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RulesEngineAction)} does not support '{options.Format}' format.");
            }
        }

        RulesEngineAction IPersistableModel<RulesEngineAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRulesEngineAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RulesEngineAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RulesEngineAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
