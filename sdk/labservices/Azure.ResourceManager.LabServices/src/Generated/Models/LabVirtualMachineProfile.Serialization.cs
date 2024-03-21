// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabVirtualMachineProfile : IUtf8JsonSerializable, IJsonModel<LabVirtualMachineProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabVirtualMachineProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabVirtualMachineProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("createOption"u8);
            writer.WriteStringValue(CreateOption.ToSerialString());
            writer.WritePropertyName("imageReference"u8);
            writer.WriteObjectValue(ImageReference);
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            writer.WritePropertyName("usageQuota"u8);
            writer.WriteStringValue(UsageQuota, "P");
            if (Optional.IsDefined(UseSharedPassword))
            {
                writer.WritePropertyName("useSharedPassword"u8);
                writer.WriteStringValue(UseSharedPassword.Value.ToSerialString());
            }
            writer.WritePropertyName("adminUser"u8);
            writer.WriteObjectValue(AdminUser);
            if (Optional.IsDefined(NonAdminUser))
            {
                writer.WritePropertyName("nonAdminUser"u8);
                writer.WriteObjectValue(NonAdminUser);
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

        LabVirtualMachineProfile IJsonModel<LabVirtualMachineProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabVirtualMachineProfile(document.RootElement, options);
        }

        internal static LabVirtualMachineProfile DeserializeLabVirtualMachineProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LabVirtualMachineCreateOption createOption = default;
            LabVirtualMachineImageReference imageReference = default;
            LabVirtualMachineImageOSType? osType = default;
            LabServicesSku sku = default;
            LabVirtualMachineAdditionalCapability additionalCapabilities = default;
            TimeSpan usageQuota = default;
            LabServicesEnableState? useSharedPassword = default;
            LabVirtualMachineCredential adminUser = default;
            LabVirtualMachineCredential nonAdminUser = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"u8))
                {
                    createOption = property.Value.GetString().ToLabVirtualMachineCreateOption();
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = LabVirtualMachineImageReference.DeserializeLabVirtualMachineImageReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = property.Value.GetString().ToLabVirtualMachineImageOSType();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = LabServicesSku.DeserializeLabServicesSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalCapabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalCapabilities = LabVirtualMachineAdditionalCapability.DeserializeLabVirtualMachineAdditionalCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("usageQuota"u8))
                {
                    usageQuota = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("useSharedPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSharedPassword = property.Value.GetString().ToLabServicesEnableState();
                    continue;
                }
                if (property.NameEquals("adminUser"u8))
                {
                    adminUser = LabVirtualMachineCredential.DeserializeLabVirtualMachineCredential(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nonAdminUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonAdminUser = LabVirtualMachineCredential.DeserializeLabVirtualMachineCredential(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LabVirtualMachineProfile(
                createOption,
                imageReference,
                osType,
                sku,
                additionalCapabilities,
                usageQuota,
                useSharedPassword,
                adminUser,
                nonAdminUser,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabVirtualMachineProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineProfile)} does not support '{options.Format}' format.");
            }
        }

        LabVirtualMachineProfile IPersistableModel<LabVirtualMachineProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabVirtualMachineProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabVirtualMachineProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
