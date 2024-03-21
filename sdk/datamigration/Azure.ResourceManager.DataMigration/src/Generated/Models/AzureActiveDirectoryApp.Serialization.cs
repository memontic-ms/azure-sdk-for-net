// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class AzureActiveDirectoryApp : IUtf8JsonSerializable, IJsonModel<AzureActiveDirectoryApp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureActiveDirectoryApp>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureActiveDirectoryApp>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureActiveDirectoryApp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureActiveDirectoryApp)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(AppKey))
            {
                writer.WritePropertyName("appKey"u8);
                writer.WriteStringValue(AppKey);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IgnoreAzurePermissions))
            {
                writer.WritePropertyName("ignoreAzurePermissions"u8);
                writer.WriteBooleanValue(IgnoreAzurePermissions.Value);
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

        AzureActiveDirectoryApp IJsonModel<AzureActiveDirectoryApp>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureActiveDirectoryApp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureActiveDirectoryApp)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureActiveDirectoryApp(document.RootElement, options);
        }

        internal static AzureActiveDirectoryApp DeserializeAzureActiveDirectoryApp(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string applicationId = default;
            string appKey = default;
            Guid? tenantId = default;
            bool? ignoreAzurePermissions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appKey"u8))
                {
                    appKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ignoreAzurePermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreAzurePermissions = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureActiveDirectoryApp(applicationId, appKey, tenantId, ignoreAzurePermissions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureActiveDirectoryApp>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureActiveDirectoryApp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureActiveDirectoryApp)} does not support '{options.Format}' format.");
            }
        }

        AzureActiveDirectoryApp IPersistableModel<AzureActiveDirectoryApp>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureActiveDirectoryApp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureActiveDirectoryApp(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureActiveDirectoryApp)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureActiveDirectoryApp>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
