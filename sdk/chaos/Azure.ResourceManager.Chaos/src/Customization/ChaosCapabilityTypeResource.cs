﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using Azure.Core.Pipeline;
using Azure.Core;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A Class representing a ChaosCapabilityType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ChaosCapabilityTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetChaosCapabilityTypeResource method.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `ChaosCapabilityMetadataResource` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ChaosCapabilityTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ChaosCapabilityTypeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="targetTypeName"> The targetTypeName. </param>
        /// <param name="capabilityTypeName"> The capabilityTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName, string capabilityTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _chaosCapabilityTypeCapabilityTypesClientDiagnostics;
        private readonly CapabilityTypesRestOperations _chaosCapabilityTypeCapabilityTypesRestClient;
#pragma warning disable CS0618 // Type or member is obsolete
        private readonly ChaosCapabilityTypeData _data;
#pragma warning restore CS0618 // Type or member is obsolete

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Chaos/locations/targetTypes/capabilityTypes";

        /// <summary> Initializes a new instance of the <see cref="ChaosCapabilityTypeResource"/> class for mocking. </summary>
        protected ChaosCapabilityTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosCapabilityTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ChaosCapabilityTypeResource(ArmClient client, ChaosCapabilityTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosCapabilityTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ChaosCapabilityTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _chaosCapabilityTypeCapabilityTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string chaosCapabilityTypeCapabilityTypesApiVersion);
            _chaosCapabilityTypeCapabilityTypesRestClient = new CapabilityTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosCapabilityTypeCapabilityTypesApiVersion);
#if DEBUG
            ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ChaosCapabilityTypeData Data
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
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ChaosCapabilityTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _chaosCapabilityTypeCapabilityTypesClientDiagnostics.CreateScope("ChaosCapabilityTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _chaosCapabilityTypeCapabilityTypesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var capabilityTypeResponse = CustomizationHelper.GetCapabilityTypeData(response.Value);
                return Response.FromValue(new ChaosCapabilityTypeResource(Client, capabilityTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ChaosCapabilityTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _chaosCapabilityTypeCapabilityTypesClientDiagnostics.CreateScope("ChaosCapabilityTypeResource.Get");
            scope.Start();
            try
            {
                var response = _chaosCapabilityTypeCapabilityTypesRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var capabilityTypeResponse = CustomizationHelper.GetCapabilityTypeData(response.Value);
                return Response.FromValue(new ChaosCapabilityTypeResource(Client, capabilityTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
