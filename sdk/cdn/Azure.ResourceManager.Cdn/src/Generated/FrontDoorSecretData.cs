// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the FrontDoorSecret data model.
    /// Friendly Secret name mapping to the any Secret or secret related information.
    /// Serialized Name: Secret
    /// </summary>
    public partial class FrontDoorSecretData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="FrontDoorSecretData"/>. </summary>
        public FrontDoorSecretData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorSecretData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState">
        /// Provisioning status
        /// Serialized Name: Secret.properties.provisioningState
        /// </param>
        /// <param name="deploymentStatus"> Serialized Name: Secret.properties.deploymentStatus. </param>
        /// <param name="profileName">
        /// The name of the profile which holds the secret.
        /// Serialized Name: Secret.properties.profileName
        /// </param>
        /// <param name="properties">
        /// object which contains secret parameters
        /// Serialized Name: Secret.properties.parameters
        /// Please note <see cref="FrontDoorSecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorSecretData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, string profileName, FrontDoorSecretProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            ProfileName = profileName;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Provisioning status
        /// Serialized Name: Secret.properties.provisioningState
        /// </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Serialized Name: Secret.properties.deploymentStatus. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
        /// <summary>
        /// The name of the profile which holds the secret.
        /// Serialized Name: Secret.properties.profileName
        /// </summary>
        public string ProfileName { get; }
        /// <summary>
        /// object which contains secret parameters
        /// Serialized Name: Secret.properties.parameters
        /// Please note <see cref="FrontDoorSecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
        /// </summary>
        public FrontDoorSecretProperties Properties { get; set; }
    }
}
