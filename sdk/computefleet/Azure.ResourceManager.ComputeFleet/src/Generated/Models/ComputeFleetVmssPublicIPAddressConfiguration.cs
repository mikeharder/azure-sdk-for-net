// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    /// </summary>
    public partial class ComputeFleetVmssPublicIPAddressConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmssPublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ComputeFleetVmssPublicIPAddressConfiguration(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmssPublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="properties">
        /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
        /// configuration
        /// </param>
        /// <param name="sku">
        /// Describes the public IP Sku. It can only be set with OrchestrationMode as
        /// Flexible.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetVmssPublicIPAddressConfiguration(string name, ComputeFleetVmssPublicIPAddressConfigurationProperties properties, ComputeFleetPublicIPAddressSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmssPublicIPAddressConfiguration"/> for deserialization. </summary>
        internal ComputeFleetVmssPublicIPAddressConfiguration()
        {
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
        /// configuration
        /// </summary>
        public ComputeFleetVmssPublicIPAddressConfigurationProperties Properties { get; set; }
        /// <summary>
        /// Describes the public IP Sku. It can only be set with OrchestrationMode as
        /// Flexible.
        /// </summary>
        public ComputeFleetPublicIPAddressSku Sku { get; set; }
    }
}
