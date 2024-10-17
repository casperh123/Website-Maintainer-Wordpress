// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Models
{
    /// <summary>
    /// The btrfs related information such as mount point and block device paths.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class NewBackupRole : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The full path of the block device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePath { get; set; }
#nullable restore
#else
        public string DevicePath { get; set; }
#endif
        /// <summary>The size of the new device if created as a new sparse file.</summary>
        public int? DeviceSize { get; set; }
        /// <summary>The type of the btrfs device, if `device` the block device must already exist, otherwise (with `sparseFile`) it will be created from a new (not existing) sparse file. In both cases the block device will be formatted to btrfs and mounted in the given mount point.</summary>
        public global::Enhance.Client.Models.DeviceKind? DeviceType { get; set; }
        /// <summary>The full path where the btrfs will be mounted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MountPoint { get; set; }
#nullable restore
#else
        public string MountPoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.NewBackupRole"/> and sets the default values.
        /// </summary>
        public NewBackupRole()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewBackupRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.NewBackupRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.NewBackupRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "devicePath", n => { DevicePath = n.GetStringValue(); } },
                { "deviceSize", n => { DeviceSize = n.GetIntValue(); } },
                { "deviceType", n => { DeviceType = n.GetEnumValue<global::Enhance.Client.Models.DeviceKind>(); } },
                { "mountPoint", n => { MountPoint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("devicePath", DevicePath);
            writer.WriteIntValue("deviceSize", DeviceSize);
            writer.WriteEnumValue<global::Enhance.Client.Models.DeviceKind>("deviceType", DeviceType);
            writer.WriteStringValue("mountPoint", MountPoint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618