// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class WebhookPartnerDestinationInfo : IUtf8JsonSerializable, IJsonModel<WebhookPartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebhookPartnerDestinationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebhookPartnerDestinationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureSubscriptionId))
            {
                writer.WritePropertyName("azureSubscriptionId"u8);
                writer.WriteStringValue(AzureSubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(EndpointServiceContext))
            {
                writer.WritePropertyName("endpointServiceContext"u8);
                writer.WriteStringValue(EndpointServiceContext);
            }
            if (Optional.IsCollectionDefined(ResourceMoveChangeHistory))
            {
                writer.WritePropertyName("resourceMoveChangeHistory"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceMoveChangeHistory)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUri))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EndpointBaseUri))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(EndpointBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                writer.WriteObjectValue(ClientAuthentication);
            }
            writer.WriteEndObject();
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

        WebhookPartnerDestinationInfo IJsonModel<WebhookPartnerDestinationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebhookPartnerDestinationInfo(document.RootElement, options);
        }

        internal static WebhookPartnerDestinationInfo DeserializeWebhookPartnerDestinationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string azureSubscriptionId = default;
            string resourceGroupName = default;
            string name = default;
            PartnerEndpointType endpointType = default;
            string endpointServiceContext = default;
            IList<ResourceMoveChangeHistory> resourceMoveChangeHistory = default;
            Uri endpointUri = default;
            Uri endpointBaseUri = default;
            PartnerClientAuthentication clientAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new PartnerEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointServiceContext"u8))
                {
                    endpointServiceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceMoveChangeHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceMoveChangeHistory> array = new List<ResourceMoveChangeHistory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ResourceMoveChangeHistory.DeserializeResourceMoveChangeHistory(item, options));
                    }
                    resourceMoveChangeHistory = array;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpointUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAuthentication = PartnerClientAuthentication.DeserializePartnerClientAuthentication(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebhookPartnerDestinationInfo(
                azureSubscriptionId,
                resourceGroupName,
                name,
                endpointType,
                endpointServiceContext,
                resourceMoveChangeHistory ?? new ChangeTrackingList<ResourceMoveChangeHistory>(),
                serializedAdditionalRawData,
                endpointUri,
                endpointBaseUri,
                clientAuthentication);
        }

        BinaryData IPersistableModel<WebhookPartnerDestinationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support '{options.Format}' format.");
            }
        }

        WebhookPartnerDestinationInfo IPersistableModel<WebhookPartnerDestinationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebhookPartnerDestinationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebhookPartnerDestinationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
