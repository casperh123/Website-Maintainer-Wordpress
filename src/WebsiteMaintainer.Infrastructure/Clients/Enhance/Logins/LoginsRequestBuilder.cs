// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Logins.UiPreferences;
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Logins
{
    /// <summary>
    /// Builds and executes requests for operations under \logins
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LoginsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The uiPreferences property</summary>
        public global::Enhance.Client.Logins.UiPreferences.UiPreferencesRequestBuilder UiPreferences
        {
            get => new global::Enhance.Client.Logins.UiPreferences.UiPreferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Logins.LoginsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoginsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/logins?orgId={orgId}{&limit*,offset*,realmId*,sortBy*,sortOrder*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Logins.LoginsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoginsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/logins?orgId={orgId}{&limit*,offset*,realmId*,sortBy*,sortOrder*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all logins registered in the control panel.Session holder must be an `Owner`, `SuperAdmin`, or `Sysadmin` in the MO.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.LoginsListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.LoginsListing?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.LoginsListing> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.LoginsListing>(requestInfo, global::Enhance.Client.Models.LoginsListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a login in the realm.The login will be created in the same realm that the organization is in.Session holder must have admin or support privileges in the given organization or any parent thereof.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewResourceUuid"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.NewResourceUuid?> PostAsync(global::Enhance.Client.Models.LoginInfo body, Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.NewResourceUuid> PostAsync(global::Enhance.Client.Models.LoginInfo body, Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.NewResourceUuid>(requestInfo, global::Enhance.Client.Models.NewResourceUuid.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all logins registered in the control panel.Session holder must be an `Owner`, `SuperAdmin`, or `Sysadmin` in the MO.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, "{+baseurl}/logins{?limit*,offset*,realmId*,sortBy*,sortOrder*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a login in the realm.The login will be created in the same realm that the organization is in.Session holder must have admin or support privileges in the given organization or any parent thereof.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.LoginInfo body, Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.LoginInfo body, Action<RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/logins?orgId={orgId}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Logins.LoginsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Logins.LoginsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Logins.LoginsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all logins registered in the control panel.Session holder must be an `Owner`, `SuperAdmin`, or `Sysadmin` in the MO.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoginsRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The offset from which to return items.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The id of the realm to query. Realm ids map to org ids.</summary>
            [QueryParameter("realmId")]
            public Guid? RealmId { get; set; }
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
            public global::Enhance.Client.Logins.GetSortByQueryParameterType? SortByAsGetSortByQueryParameterType { get; set; }
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
            public global::Enhance.Client.Logins.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoginsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Creates a login in the realm.The login will be created in the same realm that the organization is in.Session holder must have admin or support privileges in the given organization or any parent thereof.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoginsRequestBuilderPostQueryParameters 
        {
            /// <summary>The mandatory organization id to denote in which realm to create the login in. The login will be created in the same realm that the organization is in.</summary>
            [QueryParameter("orgId")]
            public Guid? OrgId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoginsRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Enhance.Client.Logins.LoginsRequestBuilder.LoginsRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618