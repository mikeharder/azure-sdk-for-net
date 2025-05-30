// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Parameters.Spread
{
    public partial class Alias
    {
        protected Alias() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response SpreadAsRequestBody(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SpreadAsRequestBodyAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response SpreadAsRequestBody(string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SpreadAsRequestBodyAsync(string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Response SpreadParameterWithInnerModel(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SpreadParameterWithInnerModelAsync(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Response SpreadParameterWithInnerModel(string id, string xMsTestHeader, string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SpreadParameterWithInnerModelAsync(string id, string xMsTestHeader, string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Response SpreadAsRequestParameter(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SpreadAsRequestParameterAsync(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Response SpreadAsRequestParameter(string id, string xMsTestHeader, string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SpreadAsRequestParameterAsync(string id, string xMsTestHeader, string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Response SpreadWithMultipleParameters(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SpreadWithMultipleParametersAsync(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Response SpreadWithMultipleParameters(string id, string xMsTestHeader, string requiredString, IEnumerable<int> requiredIntList, int? optionalInt = default, IEnumerable<string> optionalStringList = default, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SpreadWithMultipleParametersAsync(string id, string xMsTestHeader, string requiredString, IEnumerable<int> requiredIntList, int? optionalInt = default, IEnumerable<string> optionalStringList = default, CancellationToken cancellationToken = default) => throw null;

        public virtual Response SpreadParameterWithInnerAlias(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SpreadParameterWithInnerAliasAsync(string id, string xMsTestHeader, RequestContent content, RequestContext context = null) => throw null;

        public virtual Response SpreadParameterWithInnerAlias(string id, string xMsTestHeader, string name, int age, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SpreadParameterWithInnerAliasAsync(string id, string xMsTestHeader, string name, int age, CancellationToken cancellationToken = default) => throw null;
    }
}
