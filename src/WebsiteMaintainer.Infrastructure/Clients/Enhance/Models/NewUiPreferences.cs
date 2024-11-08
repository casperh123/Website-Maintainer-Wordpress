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
    public partial class NewUiPreferences : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fileManagerEditorFullscreen property</summary>
        public bool? FileManagerEditorFullscreen { get; set; }
        /// <summary>The fileManagerView property</summary>
        public global::Enhance.Client.Models.UiPreferencesViewKind? FileManagerView { get; set; }
        /// <summary>The serverGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ServerGroups { get; set; }
#nullable restore
#else
        public List<Guid?> ServerGroups { get; set; }
#endif
        /// <summary>The spineOpen property</summary>
        public bool? SpineOpen { get; set; }
        /// <summary>The websiteView property</summary>
        public global::Enhance.Client.Models.UiPreferencesViewKind? WebsiteView { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.NewUiPreferences"/> and sets the default values.
        /// </summary>
        public NewUiPreferences()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewUiPreferences"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.NewUiPreferences CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.NewUiPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fileManagerEditorFullscreen", n => { FileManagerEditorFullscreen = n.GetBoolValue(); } },
                { "fileManagerView", n => { FileManagerView = n.GetEnumValue<global::Enhance.Client.Models.UiPreferencesViewKind>(); } },
                { "serverGroups", n => { ServerGroups = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "spineOpen", n => { SpineOpen = n.GetBoolValue(); } },
                { "websiteView", n => { WebsiteView = n.GetEnumValue<global::Enhance.Client.Models.UiPreferencesViewKind>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("fileManagerEditorFullscreen", FileManagerEditorFullscreen);
            writer.WriteEnumValue<global::Enhance.Client.Models.UiPreferencesViewKind>("fileManagerView", FileManagerView);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("serverGroups", ServerGroups);
            writer.WriteBoolValue("spineOpen", SpineOpen);
            writer.WriteEnumValue<global::Enhance.Client.Models.UiPreferencesViewKind>("websiteView", WebsiteView);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
