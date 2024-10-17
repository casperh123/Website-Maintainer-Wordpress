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
    public partial class Backup : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The emailsCount property</summary>
        public int? EmailsCount { get; set; }
        /// <summary>The emailsSize property</summary>
        public int? EmailsSize { get; set; }
        /// <summary>The emailsStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? EmailsStatus { get; set; }
        /// <summary>The filesSize property</summary>
        public int? FilesSize { get; set; }
        /// <summary>The finishedAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinishedAt { get; set; }
#nullable restore
#else
        public string FinishedAt { get; set; }
#endif
        /// <summary>The homeDirStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? HomeDirStatus { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The kind property</summary>
        public global::Enhance.Client.Models.BackupKind? Kind { get; set; }
        /// <summary>The mysqlDbsCount property</summary>
        public int? MysqlDbsCount { get; set; }
        /// <summary>The mysqlDbsSize property</summary>
        public int? MysqlDbsSize { get; set; }
        /// <summary>The mysqlDbsStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? MysqlDbsStatus { get; set; }
        /// <summary>The size property</summary>
        public int? Size { get; set; }
        /// <summary>The snapshotDirName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SnapshotDirName { get; set; }
#nullable restore
#else
        public string SnapshotDirName { get; set; }
#endif
        /// <summary>The startedAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartedAt { get; set; }
#nullable restore
#else
        public string StartedAt { get; set; }
#endif
        /// <summary>The storageKind property</summary>
        public global::Enhance.Client.Models.BackupStorageKind? StorageKind { get; set; }
        /// <summary>The websiteId property</summary>
        public Guid? WebsiteId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.Backup"/> and sets the default values.
        /// </summary>
        public Backup()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.Backup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.Backup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.Backup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "emailsCount", n => { EmailsCount = n.GetIntValue(); } },
                { "emailsSize", n => { EmailsSize = n.GetIntValue(); } },
                { "emailsStatus", n => { EmailsStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "filesSize", n => { FilesSize = n.GetIntValue(); } },
                { "finishedAt", n => { FinishedAt = n.GetStringValue(); } },
                { "homeDirStatus", n => { HomeDirStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "kind", n => { Kind = n.GetEnumValue<global::Enhance.Client.Models.BackupKind>(); } },
                { "mysqlDbsCount", n => { MysqlDbsCount = n.GetIntValue(); } },
                { "mysqlDbsSize", n => { MysqlDbsSize = n.GetIntValue(); } },
                { "mysqlDbsStatus", n => { MysqlDbsStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "size", n => { Size = n.GetIntValue(); } },
                { "snapshotDirName", n => { SnapshotDirName = n.GetStringValue(); } },
                { "startedAt", n => { StartedAt = n.GetStringValue(); } },
                { "storageKind", n => { StorageKind = n.GetEnumValue<global::Enhance.Client.Models.BackupStorageKind>(); } },
                { "websiteId", n => { WebsiteId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("emailsCount", EmailsCount);
            writer.WriteIntValue("emailsSize", EmailsSize);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("emailsStatus", EmailsStatus);
            writer.WriteIntValue("filesSize", FilesSize);
            writer.WriteStringValue("finishedAt", FinishedAt);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("homeDirStatus", HomeDirStatus);
            writer.WriteIntValue("id", Id);
            writer.WriteEnumValue<global::Enhance.Client.Models.BackupKind>("kind", Kind);
            writer.WriteIntValue("mysqlDbsCount", MysqlDbsCount);
            writer.WriteIntValue("mysqlDbsSize", MysqlDbsSize);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("mysqlDbsStatus", MysqlDbsStatus);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("snapshotDirName", SnapshotDirName);
            writer.WriteStringValue("startedAt", StartedAt);
            writer.WriteEnumValue<global::Enhance.Client.Models.BackupStorageKind>("storageKind", StorageKind);
            writer.WriteGuidValue("websiteId", WebsiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618