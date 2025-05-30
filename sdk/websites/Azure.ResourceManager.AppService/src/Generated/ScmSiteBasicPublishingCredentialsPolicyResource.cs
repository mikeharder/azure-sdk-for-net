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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a ScmSiteBasicPublishingCredentialsPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetScmSiteBasicPublishingCredentialsPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource"/> using the GetScmSiteBasicPublishingCredentialsPolicy method.
    /// </summary>
    public partial class ScmSiteBasicPublishingCredentialsPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/scm";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/basicPublishingCredentialsPolicies";

        /// <summary> Initializes a new instance of the <see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/> class for mocking. </summary>
        protected ScmSiteBasicPublishingCredentialsPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScmSiteBasicPublishingCredentialsPolicyResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScmSiteBasicPublishingCredentialsPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scmSiteBasicPublishingCredentialsPolicyWebAppsApiVersion);
            _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scmSiteBasicPublishingCredentialsPolicyWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/scm</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetScmAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScmSiteBasicPublishingCredentialsPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.GetScmAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScmSiteBasicPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Returns whether Scm basic auth is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/scm</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetScmAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScmSiteBasicPublishingCredentialsPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteBasicPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.GetScmAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScmSiteBasicPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/scm</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateScmAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="CsmPublishingCredentialsPoliciesEntityData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScmSiteBasicPublishingCredentialsPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateScmAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.CreateUpdateScmAllowedRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<ScmSiteBasicPublishingCredentialsPolicyResource>(Response.FromValue(new ScmSiteBasicPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Description for Updates whether user publishing credentials are allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/scm</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateScmAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScmSiteBasicPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="CsmPublishingCredentialsPoliciesEntityData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScmSiteBasicPublishingCredentialsPolicyResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scmSiteBasicPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("ScmSiteBasicPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.UpdateScmAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var uri = _scmSiteBasicPublishingCredentialsPolicyWebAppsRestClient.CreateUpdateScmAllowedRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<ScmSiteBasicPublishingCredentialsPolicyResource>(Response.FromValue(new ScmSiteBasicPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}
