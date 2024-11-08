// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.V2.Apps.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.V2.Apps
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\apps
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AppsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.v2.apps.item collection</summary>
        /// <param name="position">The id of the app.</param>
        /// <returns>A <see cref="global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("app_id", position);
                return new global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.v2.apps.item collection</summary>
        /// <param name="position">The id of the app.</param>
        /// <returns>A <see cref="global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("app_id", position);
                return new global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Apps.AppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Apps.AppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
