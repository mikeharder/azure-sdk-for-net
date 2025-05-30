// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="CurrentUsagesBaseResource"/> and their operations.
    /// Each <see cref="CurrentUsagesBaseResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="CurrentUsagesBaseCollection"/> instance call the GetCurrentUsagesBases method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class CurrentUsagesBaseCollection : ArmCollection, IEnumerable<CurrentUsagesBaseResource>, IAsyncEnumerable<CurrentUsagesBaseResource>
    {
        private readonly ClientDiagnostics _currentUsagesBaseUsagesClientDiagnostics;
        private readonly UsagesRestOperations _currentUsagesBaseUsagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseCollection"/> class for mocking. </summary>
        protected CurrentUsagesBaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CurrentUsagesBaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _currentUsagesBaseUsagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", CurrentUsagesBaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CurrentUsagesBaseResource.ResourceType, out string currentUsagesBaseUsagesApiVersion);
            _currentUsagesBaseUsagesRestClient = new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, currentUsagesBaseUsagesApiVersion);
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<CurrentUsagesBaseResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _currentUsagesBaseUsagesRestClient.GetAsync(Id, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CurrentUsagesBaseResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Get");
            scope.Start();
            try
            {
                var response = _currentUsagesBaseUsagesRestClient.Get(Id, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of current usage for all resources for the scope specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CurrentUsagesBaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CurrentUsagesBaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _currentUsagesBaseUsagesRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _currentUsagesBaseUsagesRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CurrentUsagesBaseResource(Client, CurrentUsagesBaseData.DeserializeCurrentUsagesBaseData(e)), _currentUsagesBaseUsagesClientDiagnostics, Pipeline, "CurrentUsagesBaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of current usage for all resources for the scope specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CurrentUsagesBaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CurrentUsagesBaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _currentUsagesBaseUsagesRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _currentUsagesBaseUsagesRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CurrentUsagesBaseResource(Client, CurrentUsagesBaseData.DeserializeCurrentUsagesBaseData(e)), _currentUsagesBaseUsagesClientDiagnostics, Pipeline, "CurrentUsagesBaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _currentUsagesBaseUsagesRestClient.GetAsync(Id, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _currentUsagesBaseUsagesRestClient.Get(Id, resourceName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<CurrentUsagesBaseResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _currentUsagesBaseUsagesRestClient.GetAsync(Id, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CurrentUsagesBaseResource>(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<CurrentUsagesBaseResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _currentUsagesBaseUsagesRestClient.Get(Id, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CurrentUsagesBaseResource>(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CurrentUsagesBaseResource> IEnumerable<CurrentUsagesBaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CurrentUsagesBaseResource> IAsyncEnumerable<CurrentUsagesBaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
