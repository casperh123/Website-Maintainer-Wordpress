// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Servers.Item.Php.Fpm.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Servers.Item.Php.Fpm
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\php\fpm
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FpmRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.servers.item.php.fpm.item collection</summary>
        /// <param name="position">The id of the website.</param>
        /// <returns>A <see cref="global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("website_id", position);
                return new global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.servers.item.php.fpm.item collection</summary>
        /// <param name="position">The id of the website.</param>
        /// <returns>A <see cref="global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("website_id", position);
                return new global::Enhance.Client.Servers.Item.Php.Fpm.Item.WithWebsite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Php.Fpm.FpmRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FpmRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/php/fpm", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Php.Fpm.FpmRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FpmRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/php/fpm", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of php-fpm settings for each website on the server.Settings are queried from the running PHP instance for each website.Session holder must be an `Owner`, `SuperAdmin`, or `Sysadmin` in the MO.
        /// </summary>
        /// <returns>A List&lt;global::Enhance.Client.Models.WebsitePhpSettings&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Enhance.Client.Models.WebsitePhpSettings>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Enhance.Client.Models.WebsitePhpSettings>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Enhance.Client.Models.WebsitePhpSettings>(requestInfo, global::Enhance.Client.Models.WebsitePhpSettings.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Returns a list of php-fpm settings for each website on the server.Settings are queried from the running PHP instance for each website.Session holder must be an `Owner`, `SuperAdmin`, or `Sysadmin` in the MO.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Servers.Item.Php.Fpm.FpmRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Servers.Item.Php.Fpm.FpmRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Servers.Item.Php.Fpm.FpmRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FpmRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618