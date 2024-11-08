// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class ImportServerDomain : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The importServerId property</summary>
        public Guid? ImportServerId { get; set; }
        /// <summary>The kind property</summary>
        public global::Enhance.Client.Models.DomainMappingKind? Kind { get; set; }
        /// <summary>The movable property</summary>
        public bool? Movable { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ImportServerDomain"/> and sets the default values.
        /// </summary>
        public ImportServerDomain()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ImportServerDomain"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ImportServerDomain CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ImportServerDomain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "importServerId", n => { ImportServerId = n.GetGuidValue(); } },
                { "kind", n => { Kind = n.GetEnumValue<global::Enhance.Client.Models.DomainMappingKind>(); } },
                { "movable", n => { Movable = n.GetBoolValue(); } },
                { "user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("domain", Domain);
            writer.WriteGuidValue("importServerId", ImportServerId);
            writer.WriteEnumValue<global::Enhance.Client.Models.DomainMappingKind>("kind", Kind);
            writer.WriteBoolValue("movable", Movable);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
