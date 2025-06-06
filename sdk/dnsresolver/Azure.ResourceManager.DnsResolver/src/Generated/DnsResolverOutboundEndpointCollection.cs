// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsResolverOutboundEndpointResource"/> and their operations.
    /// Each <see cref="DnsResolverOutboundEndpointResource"/> in the collection will belong to the same instance of <see cref="DnsResolverResource"/>.
    /// To get a <see cref="DnsResolverOutboundEndpointCollection"/> instance call the GetDnsResolverOutboundEndpoints method from an instance of <see cref="DnsResolverResource"/>.
    /// </summary>
    public partial class DnsResolverOutboundEndpointCollection : ArmCollection, IEnumerable<DnsResolverOutboundEndpointResource>, IAsyncEnumerable<DnsResolverOutboundEndpointResource>
    {
        private readonly ClientDiagnostics _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics;
        private readonly OutboundEndpointsRestOperations _dnsResolverOutboundEndpointOutboundEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsResolverOutboundEndpointCollection"/> class for mocking. </summary>
        protected DnsResolverOutboundEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsResolverOutboundEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsResolverOutboundEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverOutboundEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverOutboundEndpointResource.ResourceType, out string dnsResolverOutboundEndpointOutboundEndpointsApiVersion);
            _dnsResolverOutboundEndpointOutboundEndpointsRestClient = new OutboundEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverOutboundEndpointOutboundEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsResolverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsResolverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsResolverOutboundEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string outboundEndpointName, DnsResolverOutboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsResolverOutboundEndpointResource>(new DnsResolverOutboundEndpointOperationSource(Client), _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics, Pipeline, _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsResolverOutboundEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string outboundEndpointName, DnsResolverOutboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsResolverOutboundEndpointResource>(new DnsResolverOutboundEndpointOperationSource(Client), _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics, Pipeline, _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of an outbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<DnsResolverOutboundEndpointResource>> GetAsync(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsResolverOutboundEndpointOutboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverOutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of an outbound endpoint for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual Response<DnsResolverOutboundEndpointResource> Get(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsResolverOutboundEndpointOutboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverOutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists outbound endpoints for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsResolverOutboundEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsResolverOutboundEndpointResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsResolverOutboundEndpointResource(Client, DnsResolverOutboundEndpointData.DeserializeDnsResolverOutboundEndpointData(e)), _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics, Pipeline, "DnsResolverOutboundEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists outbound endpoints for a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsResolverOutboundEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsResolverOutboundEndpointResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverOutboundEndpointOutboundEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsResolverOutboundEndpointResource(Client, DnsResolverOutboundEndpointData.DeserializeDnsResolverOutboundEndpointData(e)), _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics, Pipeline, "DnsResolverOutboundEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsResolverOutboundEndpointOutboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsResolverOutboundEndpointOutboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<DnsResolverOutboundEndpointResource>> GetIfExistsAsync(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dnsResolverOutboundEndpointOutboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DnsResolverOutboundEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DnsResolverOutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/outboundEndpoints/{outboundEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverOutboundEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundEndpointName"> The name of the outbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundEndpointName"/> is null. </exception>
        public virtual NullableResponse<DnsResolverOutboundEndpointResource> GetIfExists(string outboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundEndpointName, nameof(outboundEndpointName));

            using var scope = _dnsResolverOutboundEndpointOutboundEndpointsClientDiagnostics.CreateScope("DnsResolverOutboundEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dnsResolverOutboundEndpointOutboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DnsResolverOutboundEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DnsResolverOutboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsResolverOutboundEndpointResource> IEnumerable<DnsResolverOutboundEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsResolverOutboundEndpointResource> IAsyncEnumerable<DnsResolverOutboundEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
