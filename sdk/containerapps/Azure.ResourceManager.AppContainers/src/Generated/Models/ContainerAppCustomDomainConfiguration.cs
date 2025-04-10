// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties for apps environment custom domain. </summary>
    public partial class ContainerAppCustomDomainConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainConfiguration"/>. </summary>
        public ContainerAppCustomDomainConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainConfiguration"/>. </summary>
        /// <param name="customDomainVerificationId"> Id used to verify domain name ownership. </param>
        /// <param name="dnsSuffix"> Dns suffix for the environment domain. </param>
        /// <param name="certificateKeyVaultProperties"> Certificate stored in Azure Key Vault. </param>
        /// <param name="certificateValue"> PFX or PEM blob. </param>
        /// <param name="certificatePassword"> Certificate password. </param>
        /// <param name="expireOn"> Certificate expiration date. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="subjectName"> Subject name of the certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCustomDomainConfiguration(string customDomainVerificationId, string dnsSuffix, ContainerAppCertificateKeyVaultProperties certificateKeyVaultProperties, byte[] certificateValue, string certificatePassword, DateTimeOffset? expireOn, string thumbprint, string subjectName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomDomainVerificationId = customDomainVerificationId;
            DnsSuffix = dnsSuffix;
            CertificateKeyVaultProperties = certificateKeyVaultProperties;
            CertificateValue = certificateValue;
            CertificatePassword = certificatePassword;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            SubjectName = subjectName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id used to verify domain name ownership. </summary>
        [WirePath("customDomainVerificationId")]
        public string CustomDomainVerificationId { get; }
        /// <summary> Dns suffix for the environment domain. </summary>
        [WirePath("dnsSuffix")]
        public string DnsSuffix { get; set; }
        /// <summary> Certificate stored in Azure Key Vault. </summary>
        [WirePath("certificateKeyVaultProperties")]
        public ContainerAppCertificateKeyVaultProperties CertificateKeyVaultProperties { get; set; }
        /// <summary> PFX or PEM blob. </summary>
        [WirePath("certificateValue")]
        public byte[] CertificateValue { get; set; }
        /// <summary> Certificate password. </summary>
        [WirePath("certificatePassword")]
        public string CertificatePassword { get; set; }
        /// <summary> Certificate expiration date. </summary>
        [WirePath("expirationDate")]
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Certificate thumbprint. </summary>
        [WirePath("thumbprint")]
        public string Thumbprint { get; }
        /// <summary> Subject name of the certificate. </summary>
        [WirePath("subjectName")]
        public string SubjectName { get; }
    }
}
