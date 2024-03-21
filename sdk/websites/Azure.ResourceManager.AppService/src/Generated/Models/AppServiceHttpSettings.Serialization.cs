// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHttpSettings : IUtf8JsonSerializable, IJsonModel<AppServiceHttpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceHttpSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceHttpSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsHttpsRequired))
            {
                writer.WritePropertyName("requireHttps"u8);
                writer.WriteBooleanValue(IsHttpsRequired.Value);
            }
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(ForwardProxy))
            {
                writer.WritePropertyName("forwardProxy"u8);
                writer.WriteObjectValue(ForwardProxy);
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

        AppServiceHttpSettings IJsonModel<AppServiceHttpSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceHttpSettings(document.RootElement, options);
        }

        internal static AppServiceHttpSettings DeserializeAppServiceHttpSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? requireHttps = default;
            AppServiceHttpSettingsRoutes routes = default;
            AppServiceForwardProxy forwardProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireHttps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireHttps = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = AppServiceHttpSettingsRoutes.DeserializeAppServiceHttpSettingsRoutes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("forwardProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardProxy = AppServiceForwardProxy.DeserializeAppServiceForwardProxy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceHttpSettings(requireHttps, routes, forwardProxy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceHttpSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        AppServiceHttpSettings IPersistableModel<AppServiceHttpSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceHttpSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceHttpSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
