// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Communication.Chat
{
    internal partial class ChatThreadPropertiesInternal
    {
        internal static ChatThreadPropertiesInternal DeserializeChatThreadPropertiesInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string topic = default;
            DateTimeOffset createdOn = default;
            CommunicationIdentifierModel createdByCommunicationIdentifier = default;
            DateTimeOffset? deletedOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdByCommunicationIdentifier"u8))
                {
                    createdByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("deletedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatThreadPropertiesInternal(id, topic, createdOn, createdByCommunicationIdentifier, deletedOn);
        }
    }
}
