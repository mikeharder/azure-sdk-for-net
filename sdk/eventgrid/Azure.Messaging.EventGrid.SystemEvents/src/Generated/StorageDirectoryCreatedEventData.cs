// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Storage.DirectoryCreated event. </summary>
    public partial class StorageDirectoryCreatedEventData
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

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryCreatedEventData"/>. </summary>
        /// <param name="storageDiagnostics"> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageDiagnostics"/> is null. </exception>
        internal StorageDirectoryCreatedEventData(object storageDiagnostics)
        {
            Argument.AssertNotNull(storageDiagnostics, nameof(storageDiagnostics));

            StorageDiagnostics = storageDiagnostics;
        }

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryCreatedEventData"/>. </summary>
        /// <param name="api"> The name of the API/operation that triggered this event. </param>
        /// <param name="clientRequestId"> A request id provided by the client of the storage API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the storage service for the storage API operation that triggered this event. </param>
        /// <param name="eTag"> The etag of the directory at the time this event was triggered. </param>
        /// <param name="url"> The path to the directory. </param>
        /// <param name="sequencer"> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </param>
        /// <param name="identity"> The identity of the requester that triggered this event. </param>
        /// <param name="storageDiagnostics"> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageDirectoryCreatedEventData(string api, string clientRequestId, string requestId, string eTag, string url, string sequencer, string identity, object storageDiagnostics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Api = api;
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            Url = url;
            Sequencer = sequencer;
            Identity = identity;
            StorageDiagnostics = storageDiagnostics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryCreatedEventData"/> for deserialization. </summary>
        internal StorageDirectoryCreatedEventData()
        {
        }

        /// <summary> The name of the API/operation that triggered this event. </summary>
        public string Api { get; }
        /// <summary> A request id provided by the client of the storage API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The request id generated by the storage service for the storage API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> The etag of the directory at the time this event was triggered. </summary>
        public string ETag { get; }
        /// <summary> The path to the directory. </summary>
        public string Url { get; }
        /// <summary> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </summary>
        public string Sequencer { get; }
        /// <summary> The identity of the requester that triggered this event. </summary>
        public string Identity { get; }
    }
}
