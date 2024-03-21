// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyGroupSummary : IUtf8JsonSerializable, IJsonModel<PolicyGroupSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyGroupSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyGroupSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyGroupSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyGroupSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyGroupName))
            {
                writer.WritePropertyName("policyGroupName"u8);
                writer.WriteStringValue(PolicyGroupName);
            }
            if (Optional.IsDefined(Results))
            {
                writer.WritePropertyName("results"u8);
                writer.WriteObjectValue(Results);
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

        PolicyGroupSummary IJsonModel<PolicyGroupSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyGroupSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyGroupSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyGroupSummary(document.RootElement, options);
        }

        internal static PolicyGroupSummary DeserializePolicyGroupSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string policyGroupName = default;
            PolicySummaryResults results = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyGroupName"u8))
                {
                    policyGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyGroupSummary(policyGroupName, results, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyGroupSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyGroupSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyGroupSummary)} does not support '{options.Format}' format.");
            }
        }

        PolicyGroupSummary IPersistableModel<PolicyGroupSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyGroupSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyGroupSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyGroupSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyGroupSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
