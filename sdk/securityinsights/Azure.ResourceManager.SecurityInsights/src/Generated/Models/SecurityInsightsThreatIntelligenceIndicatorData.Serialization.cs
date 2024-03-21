// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsThreatIntelligenceIndicatorData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsCollectionDefined(ThreatIntelligenceTags))
            {
                writer.WritePropertyName("threatIntelligenceTags"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatIntelligenceTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(IndicatorTypes))
            {
                writer.WritePropertyName("indicatorTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IndicatorTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(PatternType))
            {
                writer.WritePropertyName("patternType"u8);
                writer.WriteStringValue(PatternType);
            }
            if (Optional.IsDefined(PatternVersion))
            {
                writer.WritePropertyName("patternVersion"u8);
                writer.WriteStringValue(PatternVersion);
            }
            if (Optional.IsCollectionDefined(KillChainPhases))
            {
                writer.WritePropertyName("killChainPhases"u8);
                writer.WriteStartArray();
                foreach (var item in KillChainPhases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ParsedPattern))
            {
                writer.WritePropertyName("parsedPattern"u8);
                writer.WriteStartArray();
                foreach (var item in ParsedPattern)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExternalId))
            {
                writer.WritePropertyName("externalId"u8);
                writer.WriteStringValue(ExternalId);
            }
            if (Optional.IsDefined(CreatedByRef))
            {
                writer.WritePropertyName("createdByRef"u8);
                writer.WriteStringValue(CreatedByRef);
            }
            if (Optional.IsDefined(IsDefanged))
            {
                writer.WritePropertyName("defanged"u8);
                writer.WriteBooleanValue(IsDefanged.Value);
            }
            if (Optional.IsDefined(ExternalLastUpdatedOn))
            {
                writer.WritePropertyName("externalLastUpdatedTimeUtc"u8);
                writer.WriteStringValue(ExternalLastUpdatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(ExternalReferences))
            {
                writer.WritePropertyName("externalReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GranularMarkings))
            {
                writer.WritePropertyName("granularMarkings"u8);
                writer.WriteStartArray();
                foreach (var item in GranularMarkings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsRevoked))
            {
                writer.WritePropertyName("revoked"u8);
                writer.WriteBooleanValue(IsRevoked.Value);
            }
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidence"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (Optional.IsCollectionDefined(ObjectMarkingRefs))
            {
                writer.WritePropertyName("objectMarkingRefs"u8);
                writer.WriteStartArray();
                foreach (var item in ObjectMarkingRefs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsCollectionDefined(ThreatTypes))
            {
                writer.WritePropertyName("threatTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ValidFrom))
            {
                writer.WritePropertyName("validFrom"u8);
                writer.WriteStringValue(ValidFrom.Value, "O");
            }
            if (Optional.IsDefined(ValidUntil))
            {
                writer.WritePropertyName("validUntil"u8);
                writer.WriteStringValue(ValidUntil.Value, "O");
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(Modified))
            {
                writer.WritePropertyName("modified"u8);
                writer.WriteStringValue(Modified);
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartObject();
                foreach (var item in Extensions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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

        SecurityInsightsThreatIntelligenceIndicatorData IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsThreatIntelligenceIndicatorData(document.RootElement, options);
        }

        internal static SecurityInsightsThreatIntelligenceIndicatorData DeserializeSecurityInsightsThreatIntelligenceIndicatorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ThreatIntelligenceResourceInnerKind kind = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyDictionary<string, BinaryData> additionalData = default;
            string friendlyName = default;
            IList<string> threatIntelligenceTags = default;
            DateTimeOffset? lastUpdatedTimeUtc = default;
            string source = default;
            string displayName = default;
            string description = default;
            IList<string> indicatorTypes = default;
            string pattern = default;
            string patternType = default;
            string patternVersion = default;
            IList<ThreatIntelligenceKillChainPhase> killChainPhases = default;
            IList<ThreatIntelligenceParsedPattern> parsedPattern = default;
            string externalId = default;
            string createdByRef = default;
            bool? defanged = default;
            DateTimeOffset? externalLastUpdatedTimeUtc = default;
            IList<ThreatIntelligenceExternalReference> externalReferences = default;
            IList<ThreatIntelligenceGranularMarkingEntity> granularMarkings = default;
            IList<string> labels = default;
            bool? revoked = default;
            int? confidence = default;
            IList<string> objectMarkingRefs = default;
            string language = default;
            IList<string> threatTypes = default;
            DateTimeOffset? validFrom = default;
            DateTimeOffset? validUntil = default;
            DateTimeOffset? created = default;
            string modified = default;
            IDictionary<string, BinaryData> extensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ThreatIntelligenceResourceInnerKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatIntelligenceTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threatIntelligenceTags = array;
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("indicatorTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            indicatorTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("pattern"u8))
                        {
                            pattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patternType"u8))
                        {
                            patternType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patternVersion"u8))
                        {
                            patternVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("killChainPhases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceKillChainPhase> array = new List<ThreatIntelligenceKillChainPhase>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceKillChainPhase.DeserializeThreatIntelligenceKillChainPhase(item, options));
                            }
                            killChainPhases = array;
                            continue;
                        }
                        if (property0.NameEquals("parsedPattern"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceParsedPattern> array = new List<ThreatIntelligenceParsedPattern>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceParsedPattern.DeserializeThreatIntelligenceParsedPattern(item, options));
                            }
                            parsedPattern = array;
                            continue;
                        }
                        if (property0.NameEquals("externalId"u8))
                        {
                            externalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByRef"u8))
                        {
                            createdByRef = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defanged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defanged = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("externalLastUpdatedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externalLastUpdatedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("externalReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceExternalReference> array = new List<ThreatIntelligenceExternalReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceExternalReference.DeserializeThreatIntelligenceExternalReference(item, options));
                            }
                            externalReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("granularMarkings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceGranularMarkingEntity> array = new List<ThreatIntelligenceGranularMarkingEntity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceGranularMarkingEntity.DeserializeThreatIntelligenceGranularMarkingEntity(item, options));
                            }
                            granularMarkings = array;
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("revoked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revoked = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("confidence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidence = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("objectMarkingRefs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            objectMarkingRefs = array;
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            language = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threatTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("validFrom"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validFrom = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("validUntil"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validUntil = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modified"u8))
                        {
                            modified = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            extensions = dictionary;
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
            return new SecurityInsightsThreatIntelligenceIndicatorData(
                id,
                name,
                type,
                systemData,
                kind,
                etag,
                serializedAdditionalRawData,
                additionalData ?? new ChangeTrackingDictionary<string, BinaryData>(),
                friendlyName,
                threatIntelligenceTags ?? new ChangeTrackingList<string>(),
                lastUpdatedTimeUtc,
                source,
                displayName,
                description,
                indicatorTypes ?? new ChangeTrackingList<string>(),
                pattern,
                patternType,
                patternVersion,
                killChainPhases ?? new ChangeTrackingList<ThreatIntelligenceKillChainPhase>(),
                parsedPattern ?? new ChangeTrackingList<ThreatIntelligenceParsedPattern>(),
                externalId,
                createdByRef,
                defanged,
                externalLastUpdatedTimeUtc,
                externalReferences ?? new ChangeTrackingList<ThreatIntelligenceExternalReference>(),
                granularMarkings ?? new ChangeTrackingList<ThreatIntelligenceGranularMarkingEntity>(),
                labels ?? new ChangeTrackingList<string>(),
                revoked,
                confidence,
                objectMarkingRefs ?? new ChangeTrackingList<string>(),
                language,
                threatTypes ?? new ChangeTrackingList<string>(),
                validFrom,
                validUntil,
                created,
                modified,
                extensions ?? new ChangeTrackingDictionary<string, BinaryData>());
        }

        BinaryData IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsThreatIntelligenceIndicatorData IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsThreatIntelligenceIndicatorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
