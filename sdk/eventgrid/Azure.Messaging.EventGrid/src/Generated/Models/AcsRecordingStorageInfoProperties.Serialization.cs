// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRecordingStorageInfoProperties
    {
        internal static AcsRecordingStorageInfoProperties DeserializeAcsRecordingStorageInfoProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AcsRecordingChunkInfoProperties> recordingChunks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingChunks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRecordingChunkInfoProperties> array = new List<AcsRecordingChunkInfoProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRecordingChunkInfoProperties.DeserializeAcsRecordingChunkInfoProperties(item));
                    }
                    recordingChunks = array;
                    continue;
                }
            }
            return new AcsRecordingStorageInfoProperties(recordingChunks ?? new ChangeTrackingList<AcsRecordingChunkInfoProperties>());
        }
    }
}
