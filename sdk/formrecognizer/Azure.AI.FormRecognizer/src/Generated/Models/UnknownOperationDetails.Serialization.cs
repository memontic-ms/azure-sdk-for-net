// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class UnknownOperationDetails
    {
        internal static UnknownOperationDetails DeserializeUnknownOperationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            DocumentOperationStatus status = default;
            int? percentCompleted = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DocumentOperationKind kind = "Unknown";
            Uri resourceLocation = default;
            string apiVersion = default;
            IReadOnlyDictionary<string, string> tags = default;
            JsonElement error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToDocumentOperationStatus();
                    continue;
                }
                if (property.NameEquals("percentCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentCompleted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DocumentOperationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
            }
            return new UnknownOperationDetails(
                operationId,
                status,
                percentCompleted,
                createdDateTime,
                lastUpdatedDateTime,
                kind,
                resourceLocation,
                apiVersion,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                error);
        }
    }
}
