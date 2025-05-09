// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorePointResource"/> and their operations.
    /// Each <see cref="RestorePointResource"/> in the collection will belong to the same instance of <see cref="RestorePointGroupResource"/>.
    /// To get a <see cref="RestorePointCollection"/> instance call the GetRestorePoints method from an instance of <see cref="RestorePointGroupResource"/>.
    /// </summary>
    public partial class RestorePointCollection : ArmCollection
    {
        private readonly ClientDiagnostics _restorePointClientDiagnostics;
        private readonly RestorePointsRestOperations _restorePointRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class for mocking. </summary>
        protected RestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorePointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", RestorePointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorePointResource.ResourceType, out string restorePointApiVersion);
            _restorePointRestClient = new RestorePointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorePointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RestorePointGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RestorePointGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create the restore point. Updating properties of an existing restore point is not allowed
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="data"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RestorePointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string restorePointName, RestorePointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<RestorePointResource>(new RestorePointOperationSource(Client), _restorePointClientDiagnostics, Pipeline, _restorePointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create the restore point. Updating properties of an existing restore point is not allowed
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="data"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RestorePointResource> CreateOrUpdate(WaitUntil waitUntil, string restorePointName, RestorePointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, data, cancellationToken);
                var operation = new ComputeArmOperation<RestorePointResource>(new RestorePointOperationSource(Client), _restorePointClientDiagnostics, Pipeline, _restorePointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the restore point.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<RestorePointResource>> GetAsync(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the restore point.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePointResource> Get(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<NullableResponse<RestorePointResource>> GetIfExistsAsync(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RestorePointResource>(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves information about the run-time state of a restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual NullableResponse<RestorePointResource> GetIfExists(string restorePointName, RestorePointExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RestorePointResource>(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
