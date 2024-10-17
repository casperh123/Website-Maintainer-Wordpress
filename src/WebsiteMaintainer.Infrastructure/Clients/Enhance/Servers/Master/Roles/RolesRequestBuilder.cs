// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Master.Roles.Control;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Master.Roles
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\master\roles
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RolesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The control property</summary>
        public global::Enhance.Client.Servers.Master.Roles.Control.ControlRequestBuilder Control
        {
            get => new global::Enhance.Client.Servers.Master.Roles.Control.ControlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Master.Roles.RolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RolesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/master/roles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Master.Roles.RolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RolesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/master/roles", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618