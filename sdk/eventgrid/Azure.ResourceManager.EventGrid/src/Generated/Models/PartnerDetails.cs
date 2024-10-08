// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the partner. </summary>
    public partial class PartnerDetails
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

        /// <summary> Initializes a new instance of <see cref="PartnerDetails"/>. </summary>
        public PartnerDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PartnerDetails"/>. </summary>
        /// <param name="description"> This is short description about the partner. The length of this description should not exceed 256 characters. </param>
        /// <param name="longDescription"> Long description for the partner's scenarios and integration.Length of this description should not exceed 2048 characters. </param>
        /// <param name="setupUri">
        /// URI of the partner website that can be used by Azure customers to setup Event Grid
        /// integration on an event source.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerDetails(string description, string longDescription, Uri setupUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            LongDescription = longDescription;
            SetupUri = setupUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This is short description about the partner. The length of this description should not exceed 256 characters. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> Long description for the partner's scenarios and integration.Length of this description should not exceed 2048 characters. </summary>
        [WirePath("longDescription")]
        public string LongDescription { get; set; }
        /// <summary>
        /// URI of the partner website that can be used by Azure customers to setup Event Grid
        /// integration on an event source.
        /// </summary>
        [WirePath("setupUri")]
        public Uri SetupUri { get; set; }
    }
}
