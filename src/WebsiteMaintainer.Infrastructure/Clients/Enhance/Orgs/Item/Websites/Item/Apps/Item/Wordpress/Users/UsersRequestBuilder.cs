// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Default;
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}\apps\{app_id}\wordpress\users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The default property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Default.DefaultRequestBuilder Default
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Default.DefaultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.websites.item.apps.item.wordpress.users.item collection</summary>
        /// <param name="position">The id of the wordpress user.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_id", position);
                return new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.websites.item.apps.item.wordpress.users.item collection</summary>
        /// <param name="position">The id of the wordpress user.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("user_id", position);
                return new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.Item.WithUser_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}/wordpress/users", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}/wordpress/users", rawUrl)
        {
        }
        /// <summary>
        /// Returns the users of this wordpress app.This is a separate endpoint as it is takes longer to return than most other endpoints.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.WpUsersFullListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.WpUsersFullListing?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.WpUsersFullListing> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.WpUsersFullListing>(requestInfo, global::Enhance.Client.Models.WpUsersFullListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new user in this wordpress app.The created user is independent from Enhance logins--it only concerns the wordpress app (which much like Enhance is its own webapp).Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Enhance.Client.Models.NewWpUser body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Enhance.Client.Models.NewWpUser body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the users of this wordpress app.This is a separate endpoint as it is takes longer to return than most other endpoints.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new user in this wordpress app.The created user is independent from Enhance logins--it only concerns the wordpress app (which much like Enhance is its own webapp).Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewWpUser body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewWpUser body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
