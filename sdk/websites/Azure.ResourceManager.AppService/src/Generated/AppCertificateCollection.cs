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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppCertificateResource"/> and their operations.
    /// Each <see cref="AppCertificateResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AppCertificateCollection"/> instance call the GetAppCertificates method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AppCertificateCollection : ArmCollection, IEnumerable<AppCertificateResource>, IAsyncEnumerable<AppCertificateResource>
    {
        private readonly ClientDiagnostics _appCertificateCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _appCertificateCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppCertificateCollection"/> class for mocking. </summary>
        protected AppCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appCertificateCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppCertificateResource.ResourceType, out string appCertificateCertificatesApiVersion);
            _appCertificateCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appCertificateCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create or update a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Details of certificate, if it exists already. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, AppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appCertificateCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppCertificateResource>(new AppCertificateOperationSource(Client), _appCertificateCertificatesClientDiagnostics, Pipeline, _appCertificateCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Details of certificate, if it exists already. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string name, AppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appCertificateCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppCertificateResource>(new AppCertificateOperationSource(Client), _appCertificateCertificatesClientDiagnostics, Pipeline, _appCertificateCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppCertificateResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _appCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppCertificateResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _appCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all certificates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appCertificateCertificatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appCertificateCertificatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppCertificateResource(Client, AppCertificateData.DeserializeAppCertificateData(e)), _appCertificateCertificatesClientDiagnostics, Pipeline, "AppCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all certificates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appCertificateCertificatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appCertificateCertificatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppCertificateResource(Client, AppCertificateData.DeserializeAppCertificateData(e)), _appCertificateCertificatesClientDiagnostics, Pipeline, "AppCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _appCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<AppCertificateResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new AppCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<AppCertificateResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appCertificateCertificatesClientDiagnostics.CreateScope("AppCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new AppCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppCertificateResource> IEnumerable<AppCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppCertificateResource> IAsyncEnumerable<AppCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
