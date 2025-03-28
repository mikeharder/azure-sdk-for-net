// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Hive Server linked service. </summary>
    public partial class HiveLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="HiveLinkedService"/>. </summary>
        /// <param name="host"> IP address or host name of the Hive server, separated by ';' for multiple hosts (only when serviceDiscoveryMode is enable). </param>
        /// <param name="authenticationType"> The authentication method used to access the Hive server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public HiveLinkedService(object host, HiveAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            AuthenticationType = authenticationType;
            Type = "Hive";
        }

        /// <summary> Initializes a new instance of <see cref="HiveLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> IP address or host name of the Hive server, separated by ';' for multiple hosts (only when serviceDiscoveryMode is enable). </param>
        /// <param name="port"> The TCP port that the Hive server uses to listen for client connections. </param>
        /// <param name="serverType"> The type of Hive server. </param>
        /// <param name="thriftTransportProtocol"> The transport protocol to use in the Thrift layer. </param>
        /// <param name="authenticationType"> The authentication method used to access the Hive server. </param>
        /// <param name="serviceDiscoveryMode"> true to indicate using the ZooKeeper service, false not. </param>
        /// <param name="zooKeeperNameSpace"> The namespace on ZooKeeper under which Hive Server 2 nodes are added. </param>
        /// <param name="useNativeQuery"> Specifies whether the driver uses native HiveQL queries,or converts them into an equivalent form in HiveQL. </param>
        /// <param name="username"> The user name that you use to access Hive Server. </param>
        /// <param name="password">
        /// The password corresponding to the user name that you provided in the Username field
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="httpPath"> The partial URL corresponding to the Hive server. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal HiveLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object port, HiveServerType? serverType, HiveThriftTransportProtocol? thriftTransportProtocol, HiveAuthenticationType authenticationType, object serviceDiscoveryMode, object zooKeeperNameSpace, object useNativeQuery, object username, SecretBase password, object httpPath, object enableSsl, object trustedCertPath, object useSystemTrustStore, object allowHostNameCNMismatch, object allowSelfSignedServerCert, object encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            ServerType = serverType;
            ThriftTransportProtocol = thriftTransportProtocol;
            AuthenticationType = authenticationType;
            ServiceDiscoveryMode = serviceDiscoveryMode;
            ZooKeeperNameSpace = zooKeeperNameSpace;
            UseNativeQuery = useNativeQuery;
            Username = username;
            Password = password;
            HttpPath = httpPath;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Hive";
        }

        /// <summary> IP address or host name of the Hive server, separated by ';' for multiple hosts (only when serviceDiscoveryMode is enable). </summary>
        public object Host { get; set; }
        /// <summary> The TCP port that the Hive server uses to listen for client connections. </summary>
        public object Port { get; set; }
        /// <summary> The type of Hive server. </summary>
        public HiveServerType? ServerType { get; set; }
        /// <summary> The transport protocol to use in the Thrift layer. </summary>
        public HiveThriftTransportProtocol? ThriftTransportProtocol { get; set; }
        /// <summary> The authentication method used to access the Hive server. </summary>
        public HiveAuthenticationType AuthenticationType { get; set; }
        /// <summary> true to indicate using the ZooKeeper service, false not. </summary>
        public object ServiceDiscoveryMode { get; set; }
        /// <summary> The namespace on ZooKeeper under which Hive Server 2 nodes are added. </summary>
        public object ZooKeeperNameSpace { get; set; }
        /// <summary> Specifies whether the driver uses native HiveQL queries,or converts them into an equivalent form in HiveQL. </summary>
        public object UseNativeQuery { get; set; }
        /// <summary> The user name that you use to access Hive Server. </summary>
        public object Username { get; set; }
        /// <summary>
        /// The password corresponding to the user name that you provided in the Username field
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The partial URL corresponding to the Hive server. </summary>
        public object HttpPath { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public object EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public object TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public object UseSystemTrustStore { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public object AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public object AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
