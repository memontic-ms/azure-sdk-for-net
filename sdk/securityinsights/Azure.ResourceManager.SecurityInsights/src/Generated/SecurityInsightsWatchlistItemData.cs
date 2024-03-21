// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsWatchlistItem data model.
    /// Represents a Watchlist Item in Azure Security Insights.
    /// </summary>
    public partial class SecurityInsightsWatchlistItemData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsWatchlistItemData"/>. </summary>
        public SecurityInsightsWatchlistItemData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsWatchlistItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="watchlistItemType"> The type of the watchlist item. </param>
        /// <param name="watchlistItemId"> The id (a Guid) of the watchlist item. </param>
        /// <param name="tenantId"> The tenantId to which the watchlist item belongs to. </param>
        /// <param name="isDeleted"> A flag that indicates if the watchlist item is deleted or not. </param>
        /// <param name="createdOn"> The time the watchlist item was created. </param>
        /// <param name="updatedOn"> The last time the watchlist item was updated. </param>
        /// <param name="createdBy"> Describes a user that created the watchlist item. </param>
        /// <param name="updatedBy"> Describes a user that updated the watchlist item. </param>
        /// <param name="itemsKeyValue"> key-value pairs for a watchlist item. </param>
        /// <param name="entityMapping"> key-value pairs for a watchlist item entity mapping. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsWatchlistItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string watchlistItemType, string watchlistItemId, Guid? tenantId, bool? isDeleted, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, SecurityInsightsUserInfo createdBy, SecurityInsightsUserInfo updatedBy, BinaryData itemsKeyValue, BinaryData entityMapping, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WatchlistItemType = watchlistItemType;
            WatchlistItemId = watchlistItemId;
            TenantId = tenantId;
            IsDeleted = isDeleted;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            ItemsKeyValue = itemsKeyValue;
            EntityMapping = entityMapping;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the watchlist item. </summary>
        public string WatchlistItemType { get; set; }
        /// <summary> The id (a Guid) of the watchlist item. </summary>
        public string WatchlistItemId { get; set; }
        /// <summary> The tenantId to which the watchlist item belongs to. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> A flag that indicates if the watchlist item is deleted or not. </summary>
        public bool? IsDeleted { get; set; }
        /// <summary> The time the watchlist item was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The last time the watchlist item was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; set; }
        /// <summary> Describes a user that created the watchlist item. </summary>
        public SecurityInsightsUserInfo CreatedBy { get; set; }
        /// <summary> Describes a user that updated the watchlist item. </summary>
        public SecurityInsightsUserInfo UpdatedBy { get; set; }
        /// <summary>
        /// key-value pairs for a watchlist item
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData ItemsKeyValue { get; set; }
        /// <summary>
        /// key-value pairs for a watchlist item entity mapping
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData EntityMapping { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
