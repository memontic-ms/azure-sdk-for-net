// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsRepoProperties : IUtf8JsonSerializable, IJsonModel<AzureDevOpsRepoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDevOpsRepoProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDevOpsRepoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDevOpsRepoProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(RepoId))
            {
                writer.WritePropertyName("repoId"u8);
                writer.WriteStringValue(RepoId);
            }
            if (Optional.IsDefined(RepoUri))
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OrgName))
            {
                writer.WritePropertyName("orgName"u8);
                writer.WriteStringValue(OrgName);
            }
            if (Optional.IsDefined(ProjectName))
            {
                writer.WritePropertyName("projectName"u8);
                writer.WriteStringValue(ProjectName);
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility);
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

        AzureDevOpsRepoProperties IJsonModel<AzureDevOpsRepoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDevOpsRepoProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDevOpsRepoProperties(document.RootElement, options);
        }

        internal static AzureDevOpsRepoProperties DeserializeAzureDevOpsRepoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            string repoId = default;
            Uri repoUrl = default;
            string orgName = default;
            string projectName = default;
            string visibility = default;
            ActionableRemediation actionableRemediation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repoId"u8))
                {
                    repoId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orgName"u8))
                {
                    orgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    visibility = property.Value.GetString();
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
            return new AzureDevOpsRepoProperties(
                provisioningState,
                repoId,
                repoUrl,
                orgName,
                projectName,
                visibility,
                actionableRemediation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureDevOpsRepoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDevOpsRepoProperties)} does not support '{options.Format}' format.");
            }
        }

        AzureDevOpsRepoProperties IPersistableModel<AzureDevOpsRepoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDevOpsRepoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDevOpsRepoProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDevOpsRepoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
