// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.Emails.Item.ClientConf
{
    [Obsolete("This class is obsolete. Use ClientConfGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ClientConfResponse : global::Enhance.Client.Orgs.Item.Websites.Item.Emails.Item.ClientConf.ClientConfGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Emails.Item.ClientConf.ClientConfResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Enhance.Client.Orgs.Item.Websites.Item.Emails.Item.ClientConf.ClientConfResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Orgs.Item.Websites.Item.Emails.Item.ClientConf.ClientConfResponse();
        }
    }
}
#pragma warning restore CS0618