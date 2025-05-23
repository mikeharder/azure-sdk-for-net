// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Custom domains created on the CDN endpoint.
    /// Serialized Name: DeepCreatedCustomDomain
    /// </summary>
    public partial class DeepCreatedCustomDomain
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

        /// <summary> Initializes a new instance of <see cref="DeepCreatedCustomDomain"/>. </summary>
        /// <param name="name">
        /// Custom domain name.
        /// Serialized Name: DeepCreatedCustomDomain.name
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal DeepCreatedCustomDomain(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeepCreatedCustomDomain"/>. </summary>
        /// <param name="name">
        /// Custom domain name.
        /// Serialized Name: DeepCreatedCustomDomain.name
        /// </param>
        /// <param name="hostName">
        /// The host name of the custom domain. Must be a domain name.
        /// Serialized Name: DeepCreatedCustomDomain.properties.hostName
        /// </param>
        /// <param name="validationData">
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
        /// Serialized Name: DeepCreatedCustomDomain.properties.validationData
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeepCreatedCustomDomain(string name, string hostName, string validationData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            HostName = hostName;
            ValidationData = validationData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeepCreatedCustomDomain"/> for deserialization. </summary>
        internal DeepCreatedCustomDomain()
        {
        }

        /// <summary>
        /// Custom domain name.
        /// Serialized Name: DeepCreatedCustomDomain.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The host name of the custom domain. Must be a domain name.
        /// Serialized Name: DeepCreatedCustomDomain.properties.hostName
        /// </summary>
        public string HostName { get; }
        /// <summary>
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
        /// Serialized Name: DeepCreatedCustomDomain.properties.validationData
        /// </summary>
        public string ValidationData { get; }
    }
}
