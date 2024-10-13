// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class NewPrimaryDomainMapping : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If this object is present, the website&apos;s .htaccess will have a new set of rules which redirect all secondary domains to this primary domain with 301 header. If this object is missing, any existing rules will be removed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.CanonicalRedirect? CanonicalRedirect { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.CanonicalRedirect CanonicalRedirect { get; set; }
#endif
        /// <summary>The domainId property</summary>
        public Guid? DomainId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.NewPrimaryDomainMapping"/> and sets the default values.
        /// </summary>
        public NewPrimaryDomainMapping()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewPrimaryDomainMapping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.NewPrimaryDomainMapping CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.NewPrimaryDomainMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "canonicalRedirect", n => { CanonicalRedirect = n.GetObjectValue<global::Enhance.Client.Models.CanonicalRedirect>(global::Enhance.Client.Models.CanonicalRedirect.CreateFromDiscriminatorValue); } },
                { "domainId", n => { DomainId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.CanonicalRedirect>("canonicalRedirect", CanonicalRedirect);
            writer.WriteGuidValue("domainId", DomainId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618