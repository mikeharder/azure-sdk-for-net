// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class PrivateLinkCollection : ArmCollection, IEnumerable<PrivateLinkResource>, IAsyncEnumerable<PrivateLinkResource>
    {
        private readonly ClientDiagnostics _privatelinkClientDiagnostics;
        private readonly PrivateLinks _privatelinkRestClient;

        /// <summary> Initializes a new instance of PrivateLinkCollection for mocking. </summary>
        protected PrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privatelinkClientDiagnostics = new ClientDiagnostics("MgmtTypeSpec", ResourceGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupResource.ResourceType, out string privatelinkApiVersion);
            _privatelinkRestClient = new PrivateLinks(_privatelinkClientDiagnostics, Pipeline, Endpoint, privatelinkApiVersion);
            ValidateResourceId(id);
        }

        /// <param name="id"></param>
        [Conditional("DEBUG")]
        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
            {
                throw new ArgumentException(string.Format("Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), id);
            }
        }

        /// <summary> list private links on the given resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> list private links on the given resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        IEnumerator<PrivateLinkResource> IEnumerable<PrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        IAsyncEnumerator<PrivateLinkResource> IAsyncEnumerable<PrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
