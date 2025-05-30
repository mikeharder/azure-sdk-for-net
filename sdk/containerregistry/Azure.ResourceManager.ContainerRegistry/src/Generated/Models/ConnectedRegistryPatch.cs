// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a connected registry. </summary>
    public partial class ConnectedRegistryPatch
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

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryPatch"/>. </summary>
        public ConnectedRegistryPatch()
        {
            ClientTokenIds = new ChangeTrackingList<ResourceIdentifier>();
            NotificationsList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryPatch"/>. </summary>
        /// <param name="syncProperties"> The parameters for updating the sync properties of the connected registry with its parent. </param>
        /// <param name="logging"> The logging properties of the connected registry. </param>
        /// <param name="clientTokenIds"> The list of the ACR token resource IDs used to authenticate clients to the connected registry. </param>
        /// <param name="notificationsList"> The list of notifications subscription information for the connected registry. </param>
        /// <param name="garbageCollection"> The garbage collection properties of the connected registry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectedRegistryPatch(ConnectedRegistrySyncUpdateProperties syncProperties, ConnectedRegistryLogging logging, IList<ResourceIdentifier> clientTokenIds, IList<string> notificationsList, GarbageCollectionProperties garbageCollection, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SyncProperties = syncProperties;
            Logging = logging;
            ClientTokenIds = clientTokenIds;
            NotificationsList = notificationsList;
            GarbageCollection = garbageCollection;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The parameters for updating the sync properties of the connected registry with its parent. </summary>
        [WirePath("properties.syncProperties")]
        public ConnectedRegistrySyncUpdateProperties SyncProperties { get; set; }
        /// <summary> The logging properties of the connected registry. </summary>
        [WirePath("properties.logging")]
        public ConnectedRegistryLogging Logging { get; set; }
        /// <summary> The list of the ACR token resource IDs used to authenticate clients to the connected registry. </summary>
        [WirePath("properties.clientTokenIds")]
        public IList<ResourceIdentifier> ClientTokenIds { get; }
        /// <summary> The list of notifications subscription information for the connected registry. </summary>
        [WirePath("properties.notificationsList")]
        public IList<string> NotificationsList { get; }
        /// <summary> The garbage collection properties of the connected registry. </summary>
        [WirePath("properties.garbageCollection")]
        public GarbageCollectionProperties GarbageCollection { get; set; }
    }
}
