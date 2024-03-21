// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupDiscreteRecoveryPointProperties : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupDiscreteRecoveryPointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupDiscreteRecoveryPointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupDiscreteRecoveryPointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupDiscreteRecoveryPointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsCollectionDefined(RecoveryPointDataStoresDetails))
            {
                writer.WritePropertyName("recoveryPointDataStoresDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointDataStoresDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("recoveryPointTime"u8);
            writer.WriteStringValue(RecoverOn, "O");
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(PolicyVersion))
            {
                writer.WritePropertyName("policyVersion"u8);
                writer.WriteStringValue(PolicyVersion);
            }
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(RecoveryPointType))
            {
                writer.WritePropertyName("recoveryPointType"u8);
                writer.WriteStringValue(RecoveryPointType);
            }
            if (Optional.IsDefined(RetentionTagName))
            {
                writer.WritePropertyName("retentionTagName"u8);
                writer.WriteStringValue(RetentionTagName);
            }
            if (Optional.IsDefined(RetentionTagVersion))
            {
                writer.WritePropertyName("retentionTagVersion"u8);
                writer.WriteStringValue(RetentionTagVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointState))
            {
                writer.WritePropertyName("recoveryPointState"u8);
                writer.WriteStringValue(RecoveryPointState.Value.ToString());
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        DataProtectionBackupDiscreteRecoveryPointProperties IJsonModel<DataProtectionBackupDiscreteRecoveryPointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupDiscreteRecoveryPointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupDiscreteRecoveryPointProperties(document.RootElement, options);
        }

        internal static DataProtectionBackupDiscreteRecoveryPointProperties DeserializeDataProtectionBackupDiscreteRecoveryPointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            IList<RecoveryPointDataStoreDetail> recoveryPointDataStoresDetails = default;
            DateTimeOffset recoveryPointTime = default;
            string policyName = default;
            string policyVersion = default;
            string recoveryPointId = default;
            string recoveryPointType = default;
            string retentionTagName = default;
            string retentionTagVersion = default;
            DateTimeOffset? expiryTime = default;
            DataProtectionBackupRecoveryPointCompletionState? recoveryPointState = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointDataStoresDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointDataStoreDetail> array = new List<RecoveryPointDataStoreDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointDataStoreDetail.DeserializeRecoveryPointDataStoreDetail(item, options));
                    }
                    recoveryPointDataStoresDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyVersion"u8))
                {
                    policyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionTagName"u8))
                {
                    retentionTagName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionTagVersion"u8))
                {
                    retentionTagVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointState = new DataProtectionBackupRecoveryPointCompletionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProtectionBackupDiscreteRecoveryPointProperties(
                objectType,
                serializedAdditionalRawData,
                friendlyName,
                recoveryPointDataStoresDetails ?? new ChangeTrackingList<RecoveryPointDataStoreDetail>(),
                recoveryPointTime,
                policyName,
                policyVersion,
                recoveryPointId,
                recoveryPointType,
                retentionTagName,
                retentionTagVersion,
                expiryTime,
                recoveryPointState);
        }

        BinaryData IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupDiscreteRecoveryPointProperties)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupDiscreteRecoveryPointProperties IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupDiscreteRecoveryPointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupDiscreteRecoveryPointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupDiscreteRecoveryPointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
