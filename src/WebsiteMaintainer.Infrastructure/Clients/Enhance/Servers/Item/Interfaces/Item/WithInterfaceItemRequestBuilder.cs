// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Item.Interfaces.Item.Ips;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Item.Interfaces.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\interfaces\{interface}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithInterfaceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ips property</summary>
        public global::Enhance.Client.Servers.Item.Interfaces.Item.Ips.IpsRequestBuilder Ips
        {
            get => new global::Enhance.Client.Servers.Item.Interfaces.Item.Ips.IpsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Interfaces.Item.WithInterfaceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInterfaceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/interfaces/{interface}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Interfaces.Item.WithInterfaceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInterfaceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/interfaces/{interface}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
