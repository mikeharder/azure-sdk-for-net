// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Router Job Worker Selector. </summary>
    public partial class AcsRouterWorkerSelector
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

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerSelector"/>. </summary>
        /// <param name="labelValue"> Router Job Worker Selector Value. </param>
        /// <param name="ttlSeconds"> Router Job Worker Selector Time to Live in Seconds. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="labelValue"/> is null. </exception>
        internal AcsRouterWorkerSelector(object labelValue, double? ttlSeconds)
        {
            Argument.AssertNotNull(labelValue, nameof(labelValue));

            LabelValue = labelValue;
            TtlSeconds = ttlSeconds;
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerSelector"/>. </summary>
        /// <param name="key"> Router Job Worker Selector Key. </param>
        /// <param name="operator"> Router Job Worker Selector Label Operator. </param>
        /// <param name="labelValue"> Router Job Worker Selector Value. </param>
        /// <param name="ttlSeconds"> Router Job Worker Selector Time to Live in Seconds. </param>
        /// <param name="selectorState"> Router Job Worker Selector State. </param>
        /// <param name="expirationTime"> Router Job Worker Selector Expiration Time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsRouterWorkerSelector(string key, AcsRouterLabelOperator? @operator, object labelValue, double? ttlSeconds, AcsRouterWorkerSelectorState? selectorState, DateTimeOffset? expirationTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Operator = @operator;
            LabelValue = labelValue;
            TtlSeconds = ttlSeconds;
            SelectorState = selectorState;
            ExpirationTime = expirationTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerSelector"/> for deserialization. </summary>
        internal AcsRouterWorkerSelector()
        {
        }

        /// <summary> Router Job Worker Selector Key. </summary>
        public string Key { get; }
        /// <summary> Router Job Worker Selector Expiration Time. </summary>
        public DateTimeOffset? ExpirationTime { get; }
    }
}
