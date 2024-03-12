// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A single message within an assistant thread, as provided during that thread's creation for its initial state. </summary>
    public partial class ThreadInitializationMessage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ThreadInitializationMessage"/>. </summary>
        /// <param name="role"> The role associated with the assistant thread message. Currently, only 'user' is supported when providing initial messages to a new thread. </param>
        /// <param name="content"> The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via a separate call to the create message API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public ThreadInitializationMessage(MessageRole role, string content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Role = role;
            Content = content;
            FileIds = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreadInitializationMessage"/>. </summary>
        /// <param name="role"> The role associated with the assistant thread message. Currently, only 'user' is supported when providing initial messages to a new thread. </param>
        /// <param name="content"> The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via a separate call to the create message API. </param>
        /// <param name="fileIds">
        /// A list of file IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can
        /// access files.
        /// </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadInitializationMessage(MessageRole role, string content, IList<string> fileIds, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            FileIds = fileIds;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadInitializationMessage"/> for deserialization. </summary>
        internal ThreadInitializationMessage()
        {
        }

        /// <summary> The role associated with the assistant thread message. Currently, only 'user' is supported when providing initial messages to a new thread. </summary>
        public MessageRole Role { get; }
        /// <summary> The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via a separate call to the create message API. </summary>
        public string Content { get; }
        /// <summary>
        /// A list of file IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can
        /// access files.
        /// </summary>
        public IList<string> FileIds { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
