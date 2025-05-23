// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadPropertiesUpdatedPerUser event. </summary>
    public partial class AcsChatThreadPropertiesUpdatedPerUserEventData : AcsChatThreadEventBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatThreadPropertiesUpdatedPerUserEventData"/>. </summary>
        /// <param name="recipientCommunicationIdentifier"> The communication identifier of the target user. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="editedByCommunicationIdentifier"> The communication identifier of the user who updated the thread properties. </param>
        /// <param name="properties"> The updated thread properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recipientCommunicationIdentifier"/>, <paramref name="threadId"/>, <paramref name="editedByCommunicationIdentifier"/> or <paramref name="properties"/> is null. </exception>
        internal AcsChatThreadPropertiesUpdatedPerUserEventData(CommunicationIdentifierModel recipientCommunicationIdentifier, string threadId, CommunicationIdentifierModel editedByCommunicationIdentifier, IReadOnlyDictionary<string, BinaryData> properties) : base(recipientCommunicationIdentifier, threadId)
        {
            Argument.AssertNotNull(recipientCommunicationIdentifier, nameof(recipientCommunicationIdentifier));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(editedByCommunicationIdentifier, nameof(editedByCommunicationIdentifier));
            Argument.AssertNotNull(properties, nameof(properties));

            EditedByCommunicationIdentifier = editedByCommunicationIdentifier;
            Metadata = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadPropertiesUpdatedPerUserEventData"/>. </summary>
        /// <param name="recipientCommunicationIdentifier"> The communication identifier of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="editedByCommunicationIdentifier"> The communication identifier of the user who updated the thread properties. </param>
        /// <param name="editTime"> The time at which the properties of the thread were updated. </param>
        /// <param name="metadata"> The thread metadata. </param>
        /// <param name="properties"> The updated thread properties. </param>
        internal AcsChatThreadPropertiesUpdatedPerUserEventData(CommunicationIdentifierModel recipientCommunicationIdentifier, string transactionId, string threadId, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel editedByCommunicationIdentifier, DateTimeOffset? editTime, IReadOnlyDictionary<string, string> metadata, IReadOnlyDictionary<string, BinaryData> properties) : base(recipientCommunicationIdentifier, transactionId, threadId, serializedAdditionalRawData, createTime, version)
        {
            EditedByCommunicationIdentifier = editedByCommunicationIdentifier;
            EditTime = editTime;
            Metadata = metadata;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadPropertiesUpdatedPerUserEventData"/> for deserialization. </summary>
        internal AcsChatThreadPropertiesUpdatedPerUserEventData()
        {
        }

        /// <summary> The communication identifier of the user who updated the thread properties. </summary>
        public CommunicationIdentifierModel EditedByCommunicationIdentifier { get; }
        /// <summary> The time at which the properties of the thread were updated. </summary>
        public DateTimeOffset? EditTime { get; }
        /// <summary> The thread metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary>
        /// The updated thread properties
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
        public IReadOnlyDictionary<string, BinaryData> Properties { get; }
    }
}
