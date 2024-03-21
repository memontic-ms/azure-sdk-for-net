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
    public partial class WebTestPropertiesValidationRules : IUtf8JsonSerializable, IJsonModel<WebTestPropertiesValidationRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebTestPropertiesValidationRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebTestPropertiesValidationRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesValidationRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentValidation))
            {
                writer.WritePropertyName("ContentValidation"u8);
                writer.WriteObjectValue(ContentValidation);
            }
            if (Optional.IsDefined(CheckSsl))
            {
                writer.WritePropertyName("SSLCheck"u8);
                writer.WriteBooleanValue(CheckSsl.Value);
            }
            if (Optional.IsDefined(SSLCertRemainingLifetimeCheck))
            {
                writer.WritePropertyName("SSLCertRemainingLifetimeCheck"u8);
                writer.WriteNumberValue(SSLCertRemainingLifetimeCheck.Value);
            }
            if (Optional.IsDefined(ExpectedHttpStatusCode))
            {
                writer.WritePropertyName("ExpectedHttpStatusCode"u8);
                writer.WriteNumberValue(ExpectedHttpStatusCode.Value);
            }
            if (Optional.IsDefined(IgnoreHttpStatusCode))
            {
                writer.WritePropertyName("IgnoreHttpStatusCode"u8);
                writer.WriteBooleanValue(IgnoreHttpStatusCode.Value);
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

        WebTestPropertiesValidationRules IJsonModel<WebTestPropertiesValidationRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesValidationRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestPropertiesValidationRules(document.RootElement, options);
        }

        internal static WebTestPropertiesValidationRules DeserializeWebTestPropertiesValidationRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebTestPropertiesValidationRulesContentValidation contentValidation = default;
            bool? sslCheck = default;
            int? sslCertRemainingLifetimeCheck = default;
            int? expectedHttpStatusCode = default;
            bool? ignoreHttpStatusCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ContentValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentValidation = WebTestPropertiesValidationRulesContentValidation.DeserializeWebTestPropertiesValidationRulesContentValidation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("SSLCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SSLCertRemainingLifetimeCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertRemainingLifetimeCheck = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ExpectedHttpStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedHttpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("IgnoreHttpStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreHttpStatusCode = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebTestPropertiesValidationRules(
                contentValidation,
                sslCheck,
                sslCertRemainingLifetimeCheck,
                expectedHttpStatusCode,
                ignoreHttpStatusCode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebTestPropertiesValidationRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesValidationRules)} does not support '{options.Format}' format.");
            }
        }

        WebTestPropertiesValidationRules IPersistableModel<WebTestPropertiesValidationRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebTestPropertiesValidationRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesValidationRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebTestPropertiesValidationRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
