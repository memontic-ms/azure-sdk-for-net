// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskProperties : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsCloneable))
            {
                writer.WritePropertyName("isCloneable"u8);
                writer.WriteBooleanValue(IsCloneable.Value);
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Commands))
            {
                writer.WritePropertyName("commands"u8);
                writer.WriteStartArray();
                foreach (var item in Commands)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientData))
            {
                writer.WritePropertyName("clientData"u8);
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        MigrateMySqlAzureDBForMySqlOfflineTaskProperties IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskProperties(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlOfflineTaskProperties DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MigrateMySqlAzureDBForMySqlOfflineTaskInput input = default;
            IReadOnlyList<MigrateMySqlAzureDBForMySqlOfflineTaskOutput> output = default;
            bool? isCloneable = default;
            string taskId = default;
            TaskType taskType = default;
            IReadOnlyList<ODataError> errors = default;
            TaskState? state = default;
            IReadOnlyList<CommandProperties> commands = default;
            IDictionary<string, string> clientData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = MigrateMySqlAzureDBForMySqlOfflineTaskInput.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigrateMySqlAzureDBForMySqlOfflineTaskOutput> array = new List<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateMySqlAzureDBForMySqlOfflineTaskOutput.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(item, options));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("isCloneable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCloneable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item, options));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    clientData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateMySqlAzureDBForMySqlOfflineTaskProperties(
                taskType,
                errors ?? new ChangeTrackingList<ODataError>(),
                state,
                commands ?? new ChangeTrackingList<CommandProperties>(),
                clientData ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                input,
                output ?? new ChangeTrackingList<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>(),
                isCloneable,
                taskId);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlOfflineTaskProperties IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
