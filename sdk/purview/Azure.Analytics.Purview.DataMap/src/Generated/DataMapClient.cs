// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.DataMap
{
    // Data plane generated client.
    /// <summary> The DataMap service client. </summary>
    public partial class DataMapClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DataMapClient for mocking. </summary>
        protected DataMapClient()
        {
        }

        /// <summary> Initializes a new instance of DataMapClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DataMapClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new DataMapClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DataMapClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DataMapClient(Uri endpoint, TokenCredential credential, DataMapClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new DataMapClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Relationship _cachedRelationship;

        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        public virtual Entity GetEntityClient(string apiVersion = "2023-09-01")
        {
            return new Entity(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Glossary. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        public virtual Glossary GetGlossaryClient(string apiVersion = "2023-09-01")
        {
            return new Glossary(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Discovery. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Discovery GetDiscoveryClient(string apiVersion = "2023-09-01")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Discovery(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Lineage. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Lineage GetLineageClient(string apiVersion = "2023-09-01")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Lineage(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Relationship. </summary>
        public virtual Relationship GetRelationshipClient()
        {
            return Volatile.Read(ref _cachedRelationship) ?? Interlocked.CompareExchange(ref _cachedRelationship, new Relationship(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint), null) ?? _cachedRelationship;
        }

        /// <summary> Initializes a new instance of TypeDefinition. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        public virtual TypeDefinition GetTypeDefinitionClient(string apiVersion = "2023-09-01")
        {
            return new TypeDefinition(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }
    }
}
