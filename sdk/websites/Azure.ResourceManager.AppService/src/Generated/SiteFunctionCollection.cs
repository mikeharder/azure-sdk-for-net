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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteFunctionResource"/> and their operations.
    /// Each <see cref="SiteFunctionResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="SiteFunctionCollection"/> instance call the GetSiteFunctions method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class SiteFunctionCollection : ArmCollection, IEnumerable<SiteFunctionResource>, IAsyncEnumerable<SiteFunctionResource>
    {
        private readonly ClientDiagnostics _siteFunctionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteFunctionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class for mocking. </summary>
        protected SiteFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteFunctionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteFunctionResource.ResourceType, out string siteFunctionWebAppsApiVersion);
            _siteFunctionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteFunctionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create function for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="data"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string functionName, FunctionEnvelopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.CreateFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteFunctionResource>(new SiteFunctionOperationSource(Client), _siteFunctionWebAppsClientDiagnostics, Pipeline, _siteFunctionWebAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create function for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="data"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string functionName, FunctionEnvelopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.CreateFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteFunctionResource>(new SiteFunctionOperationSource(Client), _siteFunctionWebAppsClientDiagnostics, Pipeline, _siteFunctionWebAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get function information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<SiteFunctionResource>> GetAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get function information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<SiteFunctionResource> Get(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List the functions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListFunctions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteFunctionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteFunctionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteFunctionWebAppsRestClient.CreateListFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteFunctionWebAppsRestClient.CreateListFunctionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteFunctionResource(Client, FunctionEnvelopeData.DeserializeFunctionEnvelopeData(e)), _siteFunctionWebAppsClientDiagnostics, Pipeline, "SiteFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List the functions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListFunctions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteFunctionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteFunctionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteFunctionWebAppsRestClient.CreateListFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteFunctionWebAppsRestClient.CreateListFunctionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteFunctionResource(Client, FunctionEnvelopeData.DeserializeFunctionEnvelopeData(e)), _siteFunctionWebAppsClientDiagnostics, Pipeline, "SiteFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteFunctionResource>> GetIfExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteFunctionResource>(response.GetRawResponse());
                return Response.FromValue(new SiteFunctionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFunction</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual NullableResponse<SiteFunctionResource> GetIfExists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteFunctionResource>(response.GetRawResponse());
                return Response.FromValue(new SiteFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteFunctionResource> IEnumerable<SiteFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteFunctionResource> IAsyncEnumerable<SiteFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
