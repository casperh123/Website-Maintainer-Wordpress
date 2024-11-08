// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Master.Roles;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Master
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\master
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class MasterRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The roles property</summary>
        public global::Enhance.Client.Servers.Master.Roles.RolesRequestBuilder Roles
        {
            get => new global::Enhance.Client.Servers.Master.Roles.RolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Master.MasterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MasterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/master", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Master.MasterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MasterRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/master", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
