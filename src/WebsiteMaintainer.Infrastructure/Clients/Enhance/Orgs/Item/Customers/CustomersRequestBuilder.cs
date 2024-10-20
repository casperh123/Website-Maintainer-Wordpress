// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Orgs.Item.Customers.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Customers
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\customers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.orgs.item.customers.item collection</summary>
        /// <param name="position">The organization id of the organization&apos;s customer.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("customer_org_id", position);
                return new global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.customers.item collection</summary>
        /// <param name="position">The organization id of the organization&apos;s customer.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("customer_org_id", position);
                return new global::Enhance.Client.Orgs.Item.Customers.Item.WithCustomer_org_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/customers{?limit*,maxDepth*,offset*,planId*,recursive*,sortBy*,sortOrder*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/customers{?limit*,maxDepth*,offset*,planId*,recursive*,sortBy*,sortOrder*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the list of customers of a reseller organization.If the recursive flag is set, the customers of reseller customers are returned as well recursively, up to an optional max depth value.Note, for performance it is not checked whether org is a reseller. If it is not, an empty list is returned.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.CustomersListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.CustomersListing?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder.CustomersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.CustomersListing> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder.CustomersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.CustomersListing>(requestInfo, global::Enhance.Client.Models.CustomersListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Once customer is successfully created under parent organization (identified by org_id), the customer organization&apos;s id is returned. This operation can only be done by a logged in superadmin or owner of the organization or its parent organization(s).
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewResourceUuid"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.NewResourceUuid?> PostAsync(global::Enhance.Client.Models.NewCustomer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.NewResourceUuid> PostAsync(global::Enhance.Client.Models.NewCustomer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.NewResourceUuid>(requestInfo, global::Enhance.Client.Models.NewResourceUuid.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the list of customers of a reseller organization.If the recursive flag is set, the customers of reseller customers are returned as well recursively, up to an optional max depth value.Note, for performance it is not checked whether org is a reseller. If it is not, an empty list is returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder.CustomersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder.CustomersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Once customer is successfully created under parent organization (identified by org_id), the customer organization&apos;s id is returned. This operation can only be done by a logged in superadmin or owner of the organization or its parent organization(s).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewCustomer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewCustomer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the list of customers of a reseller organization.If the recursive flag is set, the customers of reseller customers are returned as well recursively, up to an optional max depth value.Note, for performance it is not checked whether org is a reseller. If it is not, an empty list is returned.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomersRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>If recursive is set to true, this can be specified to limit the recursion depth. By default there is no recursion bound.</summary>
            [QueryParameter("maxDepth")]
            public int? MaxDepth { get; set; }
            /// <summary>The offset from which to return items.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Limit the result set to resources under subscriptions to the plan.</summary>
            [QueryParameter("planId")]
            public int? PlanId { get; set; }
            /// <summary>If set to true, the endpoint will return resources in some hierarchy recursively, that is, several or all levels of the hierarchy, depending on whether `maxDepth` is set.E.g. for customers this means direct and indirect customers are returned. For websites, this returns websites of all direct and indirect customers.</summary>
            [QueryParameter("recursive")]
            public bool? Recursive { get; set; }
            /// <summary>The field by which to sort.</summary>
            [Obsolete("This property is deprecated, use SortByAsGetSortByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string SortBy { get; set; }
#endif
            /// <summary>The field by which to sort.</summary>
            [QueryParameter("sortBy")]
            public global::Enhance.Client.Orgs.Item.Customers.GetSortByQueryParameterType? SortByAsGetSortByQueryParameterType { get; set; }
            /// <summary>The direction in which to sort. Possible values are &apos;asc&apos; and &apos;desc&apos;, defaulting to &apos;asc&apos;.</summary>
            [Obsolete("This property is deprecated, use SortOrderAsGetSortOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public string SortOrder { get; set; }
#endif
            /// <summary>The direction in which to sort. Possible values are &apos;asc&apos; and &apos;desc&apos;, defaulting to &apos;asc&apos;.</summary>
            [QueryParameter("sortOrder")]
            public global::Enhance.Client.Orgs.Item.Customers.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
            /// <summary>Filters the customers list by its status.</summary>
            [Obsolete("This property is deprecated, use StatusAsGetStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public string? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public string Status { get; set; }
#endif
            /// <summary>Filters the customers list by its status.</summary>
            [QueryParameter("status")]
            public global::Enhance.Client.Orgs.Item.Customers.GetStatusQueryParameterType? StatusAsGetStatusQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.Customers.CustomersRequestBuilder.CustomersRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
