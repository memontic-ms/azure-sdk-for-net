// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RestorableLocationResourceInfo : IUtf8JsonSerializable, IJsonModel<RestorableLocationResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorableLocationResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorableLocationResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableLocationResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableLocationResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LocationName))
            {
                writer.WritePropertyName("locationName"u8);
                writer.WriteStringValue(LocationName.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RegionalDatabaseAccountInstanceId))
            {
                writer.WritePropertyName("regionalDatabaseAccountInstanceId"u8);
                writer.WriteStringValue(RegionalDatabaseAccountInstanceId);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DeletedOn))
            {
                writer.WritePropertyName("deletionTime"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
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

        RestorableLocationResourceInfo IJsonModel<RestorableLocationResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableLocationResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorableLocationResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableLocationResourceInfo(document.RootElement, options);
        }

        internal static RestorableLocationResourceInfo DeserializeRestorableLocationResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? locationName = default;
            string regionalDatabaseAccountInstanceId = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? deletionTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locationName = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionalDatabaseAccountInstanceId"u8))
                {
                    regionalDatabaseAccountInstanceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deletionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorableLocationResourceInfo(locationName, regionalDatabaseAccountInstanceId, creationTime, deletionTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestorableLocationResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableLocationResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestorableLocationResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        RestorableLocationResourceInfo IPersistableModel<RestorableLocationResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorableLocationResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorableLocationResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestorableLocationResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorableLocationResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
