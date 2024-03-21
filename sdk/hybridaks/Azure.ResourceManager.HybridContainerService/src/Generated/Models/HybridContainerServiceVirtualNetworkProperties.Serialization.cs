// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HybridContainerServiceVirtualNetworkProperties : IUtf8JsonSerializable, IJsonModel<HybridContainerServiceVirtualNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridContainerServiceVirtualNetworkProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridContainerServiceVirtualNetworkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceVirtualNetworkProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InfraVnetProfile))
            {
                writer.WritePropertyName("infraVnetProfile"u8);
                writer.WriteObjectValue(InfraVnetProfile);
            }
            if (Optional.IsCollectionDefined(VipPool))
            {
                writer.WritePropertyName("vipPool"u8);
                writer.WriteStartArray();
                foreach (var item in VipPool)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmipPool))
            {
                writer.WritePropertyName("vmipPool"u8);
                writer.WriteStartArray();
                foreach (var item in VmipPool)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Gateway))
            {
                writer.WritePropertyName("gateway"u8);
                writer.WriteStringValue(Gateway);
            }
            if (Optional.IsDefined(IPAddressPrefix))
            {
                writer.WritePropertyName("ipAddressPrefix"u8);
                writer.WriteStringValue(IPAddressPrefix);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanID"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        HybridContainerServiceVirtualNetworkProperties IJsonModel<HybridContainerServiceVirtualNetworkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceVirtualNetworkProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridContainerServiceVirtualNetworkProperties(document.RootElement, options);
        }

        internal static HybridContainerServiceVirtualNetworkProperties DeserializeHybridContainerServiceVirtualNetworkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InfraVnetProfile infraVnetProfile = default;
            IList<KubernetesVirtualIPItem> vipPool = default;
            IList<VirtualMachineIPItem> vmipPool = default;
            IList<string> dnsServers = default;
            string gateway = default;
            string ipAddressPrefix = default;
            int? vlanId = default;
            HybridContainerServiceProvisioningState? provisioningState = default;
            HybridContainerServiceNetworkStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infraVnetProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infraVnetProfile = InfraVnetProfile.DeserializeInfraVnetProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vipPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesVirtualIPItem> array = new List<KubernetesVirtualIPItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesVirtualIPItem.DeserializeKubernetesVirtualIPItem(item, options));
                    }
                    vipPool = array;
                    continue;
                }
                if (property.NameEquals("vmipPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineIPItem> array = new List<VirtualMachineIPItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineIPItem.DeserializeVirtualMachineIPItem(item, options));
                    }
                    vmipPool = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("gateway"u8))
                {
                    gateway = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressPrefix"u8))
                {
                    ipAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vlanID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HybridContainerServiceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = HybridContainerServiceNetworkStatus.DeserializeHybridContainerServiceNetworkStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridContainerServiceVirtualNetworkProperties(
                infraVnetProfile,
                vipPool ?? new ChangeTrackingList<KubernetesVirtualIPItem>(),
                vmipPool ?? new ChangeTrackingList<VirtualMachineIPItem>(),
                dnsServers ?? new ChangeTrackingList<string>(),
                gateway,
                ipAddressPrefix,
                vlanId,
                provisioningState,
                status,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridContainerServiceVirtualNetworkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceVirtualNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        HybridContainerServiceVirtualNetworkProperties IPersistableModel<HybridContainerServiceVirtualNetworkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridContainerServiceVirtualNetworkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceVirtualNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridContainerServiceVirtualNetworkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
