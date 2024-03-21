// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ScalarQuantizationParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QuantizedDataType))
            {
                if (QuantizedDataType != null)
                {
                    writer.WritePropertyName("quantizedDataType"u8);
                    writer.WriteStringValue(QuantizedDataType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("quantizedDataType");
                }
            }
            writer.WriteEndObject();
        }

        internal static ScalarQuantizationParameters DeserializeScalarQuantizationParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VectorSearchCompressionTargetDataType? quantizedDataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quantizedDataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        quantizedDataType = null;
                        continue;
                    }
                    quantizedDataType = new VectorSearchCompressionTargetDataType(property.Value.GetString());
                    continue;
                }
            }
            return new ScalarQuantizationParameters(quantizedDataType);
        }
    }
}
