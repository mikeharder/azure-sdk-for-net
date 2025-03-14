// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
    public partial class SystemData
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

        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        internal SystemData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        /// <param name="createdAt"> The timestamp the resource was created at. </param>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdByType"> The identity type that created the resource. </param>
        /// <param name="lastModifiedAt"> The timestamp of resource last modification (UTC). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemData(DateTimeOffset? createdAt, string createdBy, string createdByType, DateTimeOffset? lastModifiedAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            LastModifiedAt = lastModifiedAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The timestamp the resource was created at. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; }
        /// <summary> The identity type that created the resource. </summary>
        public string CreatedByType { get; }
        /// <summary> The timestamp of resource last modification (UTC). </summary>
        public DateTimeOffset? LastModifiedAt { get; }
    }
}
