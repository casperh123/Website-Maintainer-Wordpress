// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}\mysql-dbs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MysqlDbsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.orgs.item.websites.item.mysqlDbs.item collection</summary>
        /// <param name="position">The id of the database.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("db_id", position);
                return new global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.websites.item.mysqlDbs.item collection</summary>
        /// <param name="position">The id of the database.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("db_id", position);
                return new global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.Item.WithDb_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MysqlDbsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/mysql-dbs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MysqlDbsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/mysql-dbs", rawUrl)
        {
        }
        /// <summary>
        /// Returns all MySQL databases belonging to the given website.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.MySQLDBsFullListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.MySQLDBsFullListing?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.MySQLDBsFullListing> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.MySQLDBsFullListing>(requestInfo, global::Enhance.Client.Models.MySQLDBsFullListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new MySQL database for the given website.The supplied name must conform to the following regular expression: `^[0-9a-z$_]+$`. That is, a name may only contain alphanumerical characters, dollar signs, and underscores.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewResourceUuid"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.NewResourceUuid?> PostAsync(global::Enhance.Client.Models.NewMySQLDB body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.NewResourceUuid> PostAsync(global::Enhance.Client.Models.NewMySQLDB body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.NewResourceUuid>(requestInfo, global::Enhance.Client.Models.NewResourceUuid.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all MySQL databases belonging to the given website.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
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
        /// Creates a new MySQL database for the given website.The supplied name must conform to the following regular expression: `^[0-9a-z$_]+$`. That is, a name may only contain alphanumerical characters, dollar signs, and underscores.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewMySQLDB body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewMySQLDB body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MysqlDbsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MysqlDbsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
