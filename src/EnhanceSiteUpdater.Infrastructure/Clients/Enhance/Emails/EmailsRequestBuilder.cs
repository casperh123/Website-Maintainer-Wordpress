// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Emails.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Emails
{
    /// <summary>
    /// Builds and executes requests for operations under \emails
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EmailsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.emails.item collection</summary>
        /// <param name="position">The id of the email.</param>
        /// <returns>A <see cref="global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("email_id", position);
                return new global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.emails.item collection</summary>
        /// <param name="position">The id of the email.</param>
        /// <returns>A <see cref="global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("email_id", position);
                return new global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Emails.EmailsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/emails", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Emails.EmailsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/emails", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618