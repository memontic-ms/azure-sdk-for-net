// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class LoadBalancerResourceNames : IUtf8JsonSerializable, IJsonModel<LoadBalancerResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadBalancerResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LoadBalancerName))
            {
                writer.WritePropertyName("loadBalancerName"u8);
                writer.WriteStringValue(LoadBalancerName);
            }
            if (Optional.IsCollectionDefined(FrontendIPConfigurationNames))
            {
                writer.WritePropertyName("frontendIpConfigurationNames"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurationNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendPoolNames))
            {
                writer.WritePropertyName("backendPoolNames"u8);
                writer.WriteStartArray();
                foreach (var item in BackendPoolNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HealthProbeNames))
            {
                writer.WritePropertyName("healthProbeNames"u8);
                writer.WriteStartArray();
                foreach (var item in HealthProbeNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        LoadBalancerResourceNames IJsonModel<LoadBalancerResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerResourceNames(document.RootElement, options);
        }

        internal static LoadBalancerResourceNames DeserializeLoadBalancerResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string loadBalancerName = default;
            IList<string> frontendIPConfigurationNames = default;
            IList<string> backendPoolNames = default;
            IList<string> healthProbeNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loadBalancerName"u8))
                {
                    loadBalancerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendIpConfigurationNames"u8))
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
                    frontendIPConfigurationNames = array;
                    continue;
                }
                if (property.NameEquals("backendPoolNames"u8))
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
                    backendPoolNames = array;
                    continue;
                }
                if (property.NameEquals("healthProbeNames"u8))
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
                    healthProbeNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadBalancerResourceNames(loadBalancerName, frontendIPConfigurationNames ?? new ChangeTrackingList<string>(), backendPoolNames ?? new ChangeTrackingList<string>(), healthProbeNames ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadBalancerResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerResourceNames)} does not support '{options.Format}' format.");
            }
        }

        LoadBalancerResourceNames IPersistableModel<LoadBalancerResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerResourceNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
