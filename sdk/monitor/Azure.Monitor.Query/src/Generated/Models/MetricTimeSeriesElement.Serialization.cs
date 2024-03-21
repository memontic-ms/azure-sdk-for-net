// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricTimeSeriesElement
    {
        internal static MetricTimeSeriesElement DeserializeMetricTimeSeriesElement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MetadataValue> metadatavalues = default;
            IReadOnlyList<MetricValue> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadatavalues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetadataValue> array = new List<MetadataValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataValue.DeserializeMetadataValue(item));
                    }
                    metadatavalues = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricValue> array = new List<MetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricValue.DeserializeMetricValue(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new MetricTimeSeriesElement(metadatavalues ?? new ChangeTrackingList<MetadataValue>(), data ?? new ChangeTrackingList<MetricValue>());
        }
    }
}
