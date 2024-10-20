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
namespace Enhance.Client.Servers.Item.Packages.Update
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\packages\update
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UpdateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/packages/update{?systemPackageName*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/packages/update{?systemPackageName*}", rawUrl)
        {
        }
        /// <summary>
        /// Map of upgradable system packages is returned along with latest Version if the package update is available.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.UpgradableSystemPackage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.UpgradableSystemPackage?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.UpgradableSystemPackage> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.UpgradableSystemPackage>(requestInfo, global::Enhance.Client.Models.UpgradableSystemPackage.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Can only update installed package to its latest version.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(global::Enhance.Client.Models.SystemPackage body, Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PutAsync(global::Enhance.Client.Models.SystemPackage body, Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Map of upgradable system packages is returned along with latest Version if the package update is available.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Can only update installed package to its latest version.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Enhance.Client.Models.SystemPackage body, Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Enhance.Client.Models.SystemPackage body, Action<RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Map of upgradable system packages is returned along with latest Version if the package update is available.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UpdateRequestBuilderGetQueryParameters 
        {
            [Obsolete("This property is deprecated, use SystemPackageNameAsSystemPackageName instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("systemPackageName")]
            public string? SystemPackageName { get; set; }
#nullable restore
#else
            [QueryParameter("systemPackageName")]
            public string SystemPackageName { get; set; }
#endif
            [QueryParameter("systemPackageName")]
            public global::Enhance.Client.Models.SystemPackageName? SystemPackageNameAsSystemPackageName { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UpdateRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Can only update installed package to its latest version.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UpdateRequestBuilderPutQueryParameters 
        {
            [Obsolete("This property is deprecated, use SystemPackageNameAsSystemPackageName instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("systemPackageName")]
            public string? SystemPackageName { get; set; }
#nullable restore
#else
            [QueryParameter("systemPackageName")]
            public string SystemPackageName { get; set; }
#endif
            [QueryParameter("systemPackageName")]
            public global::Enhance.Client.Models.SystemPackageName? SystemPackageNameAsSystemPackageName { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UpdateRequestBuilderPutRequestConfiguration : RequestConfiguration<global::Enhance.Client.Servers.Item.Packages.Update.UpdateRequestBuilder.UpdateRequestBuilderPutQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
