// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedAzResiliencyStatus : IUtf8JsonSerializable, IJsonModel<ManagedAzResiliencyStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedAzResiliencyStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedAzResiliencyStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedAzResiliencyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedAzResiliencyStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BaseResourceStatus))
            {
                writer.WritePropertyName("baseResourceStatus"u8);
                writer.WriteStartArray();
                foreach (var item in BaseResourceStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsClusterZoneResilient))
            {
                writer.WritePropertyName("isClusterZoneResilient"u8);
                writer.WriteBooleanValue(IsClusterZoneResilient.Value);
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

        ManagedAzResiliencyStatus IJsonModel<ManagedAzResiliencyStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedAzResiliencyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedAzResiliencyStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedAzResiliencyStatus(document.RootElement, options);
        }

        internal static ManagedAzResiliencyStatus DeserializeManagedAzResiliencyStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ResourceAzStatus> baseResourceStatus = default;
            bool? isClusterZoneResilient = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseResourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceAzStatus> array = new List<ResourceAzStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceAzStatus.DeserializeResourceAzStatus(item, options));
                    }
                    baseResourceStatus = array;
                    continue;
                }
                if (property.NameEquals("isClusterZoneResilient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isClusterZoneResilient = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedAzResiliencyStatus(baseResourceStatus ?? new ChangeTrackingList<ResourceAzStatus>(), isClusterZoneResilient, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedAzResiliencyStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedAzResiliencyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedAzResiliencyStatus)} does not support '{options.Format}' format.");
            }
        }

        ManagedAzResiliencyStatus IPersistableModel<ManagedAzResiliencyStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedAzResiliencyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedAzResiliencyStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedAzResiliencyStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedAzResiliencyStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
