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

namespace Azure.ResourceManager.PureStorageBlock
{
    /// <summary>
    /// A class representing a collection of <see cref="PureStorageAvsVmVolumeResource"/> and their operations.
    /// Each <see cref="PureStorageAvsVmVolumeResource"/> in the collection will belong to the same instance of <see cref="PureStorageAvsVmResource"/>.
    /// To get a <see cref="PureStorageAvsVmVolumeCollection"/> instance call the GetPureStorageAvsVmVolumes method from an instance of <see cref="PureStorageAvsVmResource"/>.
    /// </summary>
    public partial class PureStorageAvsVmVolumeCollection : ArmCollection, IEnumerable<PureStorageAvsVmVolumeResource>, IAsyncEnumerable<PureStorageAvsVmVolumeResource>
    {
        private readonly ClientDiagnostics _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics;
        private readonly AvsVmVolumesRestOperations _pureStorageAvsVmVolumeAvsVmVolumesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PureStorageAvsVmVolumeCollection"/> class for mocking. </summary>
        protected PureStorageAvsVmVolumeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PureStorageAvsVmVolumeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PureStorageAvsVmVolumeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PureStorageBlock", PureStorageAvsVmVolumeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PureStorageAvsVmVolumeResource.ResourceType, out string pureStorageAvsVmVolumeAvsVmVolumesApiVersion);
            _pureStorageAvsVmVolumeAvsVmVolumesRestClient = new AvsVmVolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, pureStorageAvsVmVolumeAvsVmVolumesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PureStorageAvsVmResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PureStorageAvsVmResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a volume in an AVS VM
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual async Task<Response<PureStorageAvsVmVolumeResource>> GetAsync(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = await _pureStorageAvsVmVolumeAvsVmVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PureStorageAvsVmVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a volume in an AVS VM
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual Response<PureStorageAvsVmVolumeResource> Get(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = _pureStorageAvsVmVolumeAvsVmVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PureStorageAvsVmVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List volumes in an AVS VM
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_ListByAvsVm</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PureStorageAvsVmVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PureStorageAvsVmVolumeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _pureStorageAvsVmVolumeAvsVmVolumesRestClient.CreateListByAvsVmRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _pureStorageAvsVmVolumeAvsVmVolumesRestClient.CreateListByAvsVmNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PureStorageAvsVmVolumeResource(Client, PureStorageAvsVmVolumeData.DeserializePureStorageAvsVmVolumeData(e)), _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics, Pipeline, "PureStorageAvsVmVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List volumes in an AVS VM
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_ListByAvsVm</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PureStorageAvsVmVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PureStorageAvsVmVolumeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _pureStorageAvsVmVolumeAvsVmVolumesRestClient.CreateListByAvsVmRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _pureStorageAvsVmVolumeAvsVmVolumesRestClient.CreateListByAvsVmNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PureStorageAvsVmVolumeResource(Client, PureStorageAvsVmVolumeData.DeserializePureStorageAvsVmVolumeData(e)), _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics, Pipeline, "PureStorageAvsVmVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _pureStorageAvsVmVolumeAvsVmVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = _pureStorageAvsVmVolumeAvsVmVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual async Task<NullableResponse<PureStorageAvsVmVolumeResource>> GetIfExistsAsync(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _pureStorageAvsVmVolumeAvsVmVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PureStorageAvsVmVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new PureStorageAvsVmVolumeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}/avsVms/{avsVmId}/avsVmVolumes/{volumeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsVmVolume_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageAvsVmVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeId"> ID of the volume in the AVS VM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeId"/> is null. </exception>
        public virtual NullableResponse<PureStorageAvsVmVolumeResource> GetIfExists(string volumeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeId, nameof(volumeId));

            using var scope = _pureStorageAvsVmVolumeAvsVmVolumesClientDiagnostics.CreateScope("PureStorageAvsVmVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _pureStorageAvsVmVolumeAvsVmVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PureStorageAvsVmVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new PureStorageAvsVmVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PureStorageAvsVmVolumeResource> IEnumerable<PureStorageAvsVmVolumeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PureStorageAvsVmVolumeResource> IAsyncEnumerable<PureStorageAvsVmVolumeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
