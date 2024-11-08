// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.MysqlDbs
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\mysql-dbs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class MysqlDbsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MysqlDbsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/mysql-dbs{?limit*,offset*,search*,sortBy*,sortOrder*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MysqlDbsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/mysql-dbs{?limit*,offset*,search*,sortBy*,sortOrder*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all MySQL databases belonging to the given organization.The results may optionally be filtered.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.MySQLDBsListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.MySQLDBsListing?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder.MysqlDbsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.MySQLDBsListing> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder.MysqlDbsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.MySQLDBsListing>(requestInfo, global::Enhance.Client.Models.MySQLDBsListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all MySQL databases belonging to the given organization.The results may optionally be filtered.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder.MysqlDbsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder.MysqlDbsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all MySQL databases belonging to the given organization.The results may optionally be filtered.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class MysqlDbsRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The offset from which to return items.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Limit the result set to the resources whose names, partially and case insensitively, match the specified search term.E.g. for websites, this is their domain or tag, for databases the database name, for emails the email address or mailbox name, etc.A website will also be returned if the search term exactly matches the website&apos;s uuid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
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
            public global::Enhance.Client.Orgs.Item.MysqlDbs.GetSortByQueryParameterType? SortByAsGetSortByQueryParameterType { get; set; }
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
            public global::Enhance.Client.Orgs.Item.MysqlDbs.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class MysqlDbsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.MysqlDbs.MysqlDbsRequestBuilder.MysqlDbsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
