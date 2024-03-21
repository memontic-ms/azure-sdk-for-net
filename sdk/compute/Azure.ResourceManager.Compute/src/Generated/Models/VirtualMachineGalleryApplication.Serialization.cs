// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineGalleryApplication : IUtf8JsonSerializable, IJsonModel<VirtualMachineGalleryApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineGalleryApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineGalleryApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineGalleryApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStringValue(Tags);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            writer.WritePropertyName("packageReferenceId"u8);
            writer.WriteStringValue(PackageReferenceId);
            if (Optional.IsDefined(ConfigurationReference))
            {
                writer.WritePropertyName("configurationReference"u8);
                writer.WriteStringValue(ConfigurationReference);
            }
            if (Optional.IsDefined(TreatFailureAsDeploymentFailure))
            {
                writer.WritePropertyName("treatFailureAsDeploymentFailure"u8);
                writer.WriteBooleanValue(TreatFailureAsDeploymentFailure.Value);
            }
            if (Optional.IsDefined(EnableAutomaticUpgrade))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
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

        VirtualMachineGalleryApplication IJsonModel<VirtualMachineGalleryApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineGalleryApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineGalleryApplication(document.RootElement, options);
        }

        internal static VirtualMachineGalleryApplication DeserializeVirtualMachineGalleryApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tags = default;
            int? order = default;
            string packageReferenceId = default;
            string configurationReference = default;
            bool? treatFailureAsDeploymentFailure = default;
            bool? enableAutomaticUpgrade = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    tags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("packageReferenceId"u8))
                {
                    packageReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationReference"u8))
                {
                    configurationReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("treatFailureAsDeploymentFailure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    treatFailureAsDeploymentFailure = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineGalleryApplication(
                tags,
                order,
                packageReferenceId,
                configurationReference,
                treatFailureAsDeploymentFailure,
                enableAutomaticUpgrade,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineGalleryApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineGalleryApplication)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineGalleryApplication IPersistableModel<VirtualMachineGalleryApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineGalleryApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineGalleryApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineGalleryApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
