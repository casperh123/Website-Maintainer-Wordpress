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
    public partial class UpdateImportServerSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allowPartialSync property</summary>
        public bool? AllowPartialSync { get; set; }
        /// <summary>The apiPort property</summary>
        public double? ApiPort { get; set; }
        /// <summary>The asUserRoot property</summary>
        public bool? AsUserRoot { get; set; }
        /// <summary>The authKind property</summary>
        public global::Enhance.Client.Models.ServerMigrationSettingsAuthType? AuthKind { get; set; }
        /// <summary>The authUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthUser { get; set; }
#nullable restore
#else
        public string AuthUser { get; set; }
#endif
        /// <summary>The friendlyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>The hostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>The importType property</summary>
        public global::Enhance.Client.Models.ImportKind? ImportType { get; set; }
        /// <summary>The sshPort property</summary>
        public double? SshPort { get; set; }
        /// <summary>The sshPrivateKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshPrivateKey { get; set; }
#nullable restore
#else
        public string SshPrivateKey { get; set; }
#endif
        /// <summary>The sshPublicKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshPublicKey { get; set; }
#nullable restore
#else
        public string SshPublicKey { get; set; }
#endif
        /// <summary>The sshUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshUser { get; set; }
#nullable restore
#else
        public string SshUser { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.UpdateImportServerSettings"/> and sets the default values.
        /// </summary>
        public UpdateImportServerSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.UpdateImportServerSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.UpdateImportServerSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.UpdateImportServerSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowPartialSync", n => { AllowPartialSync = n.GetBoolValue(); } },
                { "apiPort", n => { ApiPort = n.GetDoubleValue(); } },
                { "asUserRoot", n => { AsUserRoot = n.GetBoolValue(); } },
                { "authKind", n => { AuthKind = n.GetEnumValue<global::Enhance.Client.Models.ServerMigrationSettingsAuthType>(); } },
                { "authUser", n => { AuthUser = n.GetStringValue(); } },
                { "friendlyName", n => { FriendlyName = n.GetStringValue(); } },
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "importType", n => { ImportType = n.GetEnumValue<global::Enhance.Client.Models.ImportKind>(); } },
                { "sshPort", n => { SshPort = n.GetDoubleValue(); } },
                { "sshPrivateKey", n => { SshPrivateKey = n.GetStringValue(); } },
                { "sshPublicKey", n => { SshPublicKey = n.GetStringValue(); } },
                { "sshUser", n => { SshUser = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowPartialSync", AllowPartialSync);
            writer.WriteDoubleValue("apiPort", ApiPort);
            writer.WriteBoolValue("asUserRoot", AsUserRoot);
            writer.WriteEnumValue<global::Enhance.Client.Models.ServerMigrationSettingsAuthType>("authKind", AuthKind);
            writer.WriteStringValue("authUser", AuthUser);
            writer.WriteStringValue("friendlyName", FriendlyName);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteEnumValue<global::Enhance.Client.Models.ImportKind>("importType", ImportType);
            writer.WriteDoubleValue("sshPort", SshPort);
            writer.WriteStringValue("sshPrivateKey", SshPrivateKey);
            writer.WriteStringValue("sshPublicKey", SshPublicKey);
            writer.WriteStringValue("sshUser", SshUser);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618