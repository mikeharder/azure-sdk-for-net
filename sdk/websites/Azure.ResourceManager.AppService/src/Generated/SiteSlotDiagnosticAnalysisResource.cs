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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotDiagnosticAnalysis along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteSlotDiagnosticAnalysisResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteSlotDiagnosticAnalysisResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotDiagnosticResource"/> using the GetSiteSlotDiagnosticAnalysis method.
    /// </summary>
    public partial class SiteSlotDiagnosticAnalysisResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotDiagnosticAnalysisResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="siteName"> The siteName. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="diagnosticCategory"> The diagnosticCategory. </param>
        /// <param name="analysisName"> The analysisName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory, string analysisName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticAnalysisDiagnosticsRestClient;
        private readonly WebSiteAnalysisDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/diagnostics/analyses";

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisResource"/> class for mocking. </summary>
        protected SiteSlotDiagnosticAnalysisResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotDiagnosticAnalysisResource(ArmClient client, WebSiteAnalysisDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotDiagnosticAnalysisResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
            _siteSlotDiagnosticAnalysisDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WebSiteAnalysisDefinitionData Data
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
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotDiagnosticAnalysisResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotDiagnosticAnalysisResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Execute Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ExecuteSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticAnalysis>> ExecuteSiteAnalysisSlotAsync(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisResource.ExecuteSiteAnalysisSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ExecuteSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Execute Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ExecuteSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticAnalysis> ExecuteSiteAnalysisSlot(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisResource.ExecuteSiteAnalysisSlot");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ExecuteSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
