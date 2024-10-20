// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Orgs.Item.Stats.Websites.Added;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Orgs.Item.Stats.Websites
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\stats\websites
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebsitesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The added property</summary>
        public global::Enhance.Client.Orgs.Item.Stats.Websites.Added.AddedRequestBuilder Added
        {
            get => new global::Enhance.Client.Orgs.Item.Stats.Websites.Added.AddedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Stats.Websites.WebsitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebsitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/stats/websites", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Stats.Websites.WebsitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebsitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/stats/websites", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
