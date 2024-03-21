// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DevOpsProjectProperties : IUtf8JsonSerializable, IJsonModel<DevOpsProjectProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsProjectProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevOpsProjectProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsProjectProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusMessage))
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusUpdatedOn))
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ParentOrgName))
            {
                writer.WritePropertyName("parentOrgName"u8);
                writer.WriteStringValue(ParentOrgName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId);
            }
            if (Optional.IsDefined(OnboardingState))
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
            }
            if (Optional.IsDefined(ActionableRemediation))
            {
                writer.WritePropertyName("actionableRemediation"u8);
                writer.WriteObjectValue(ActionableRemediation);
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

        DevOpsProjectProperties IJsonModel<DevOpsProjectProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsProjectProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsProjectProperties(document.RootElement, options);
        }

        internal static DevOpsProjectProperties DeserializeDevOpsProjectProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningStatusMessage = default;
            DateTimeOffset? provisioningStatusUpdateTimeUtc = default;
            DevOpsProvisioningState? provisioningState = default;
            string parentOrgName = default;
            string projectId = default;
            ResourceOnboardingState? onboardingState = default;
            ActionableRemediation actionableRemediation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parentOrgName"u8))
                {
                    parentOrgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onboardingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onboardingState = new ResourceOnboardingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionableRemediation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionableRemediation = ActionableRemediation.DeserializeActionableRemediation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevOpsProjectProperties(
                provisioningStatusMessage,
                provisioningStatusUpdateTimeUtc,
                provisioningState,
                parentOrgName,
                projectId,
                onboardingState,
                actionableRemediation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevOpsProjectProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsProjectProperties)} does not support '{options.Format}' format.");
            }
        }

        DevOpsProjectProperties IPersistableModel<DevOpsProjectProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsProjectProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsProjectProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsProjectProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
