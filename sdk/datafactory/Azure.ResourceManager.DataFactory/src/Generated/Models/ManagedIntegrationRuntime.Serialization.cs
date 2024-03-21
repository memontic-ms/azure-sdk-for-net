// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ManagedIntegrationRuntime : IUtf8JsonSerializable, IJsonModel<ManagedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedIntegrationRuntime>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedIntegrationRuntime>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIntegrationRuntime)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork"u8);
                writer.WriteObjectValue(ManagedVirtualNetwork);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IntegrationRuntimeType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeProperties))
            {
                writer.WritePropertyName("computeProperties"u8);
                writer.WriteObjectValue(ComputeProperties);
            }
            if (Optional.IsDefined(SsisProperties))
            {
                writer.WritePropertyName("ssisProperties"u8);
                writer.WriteObjectValue(SsisProperties);
            }
            if (Optional.IsDefined(CustomerVirtualNetwork))
            {
                writer.WritePropertyName("customerVirtualNetwork"u8);
                writer.WriteObjectValue(CustomerVirtualNetwork);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ManagedIntegrationRuntime IJsonModel<ManagedIntegrationRuntime>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIntegrationRuntime)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIntegrationRuntime(document.RootElement, options);
        }

        internal static ManagedIntegrationRuntime DeserializeManagedIntegrationRuntime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeState? state = default;
            ManagedVirtualNetworkReference managedVirtualNetwork = default;
            IntegrationRuntimeType type = default;
            string description = default;
            IntegrationRuntimeComputeProperties computeProperties = default;
            IntegrationRuntimeSsisProperties ssisProperties = default;
            IntegrationRuntimeCustomerVirtualNetwork customerVirtualNetwork = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedVirtualNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedVirtualNetwork = ManagedVirtualNetworkReference.DeserializeManagedVirtualNetworkReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("computeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeProperties = IntegrationRuntimeComputeProperties.DeserializeIntegrationRuntimeComputeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ssisProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssisProperties = IntegrationRuntimeSsisProperties.DeserializeIntegrationRuntimeSsisProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customerVirtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerVirtualNetwork = IntegrationRuntimeCustomerVirtualNetwork.DeserializeIntegrationRuntimeCustomerVirtualNetwork(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntime(
                type,
                description,
                additionalProperties,
                state,
                managedVirtualNetwork,
                computeProperties,
                ssisProperties,
                customerVirtualNetwork);
        }

        BinaryData IPersistableModel<ManagedIntegrationRuntime>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        ManagedIntegrationRuntime IPersistableModel<ManagedIntegrationRuntime>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedIntegrationRuntime(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedIntegrationRuntime>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
