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
    public partial class BackupStatus : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::Enhance.Client.Models.BackupAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The emailsStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? EmailsStatus { get; set; }
        /// <summary>The homeDirStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? HomeDirStatus { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The mysqlDbsStatus property</summary>
        public global::Enhance.Client.Models.OperationStatus? MysqlDbsStatus { get; set; }
        /// <summary>The startedAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartedAt { get; set; }
#nullable restore
#else
        public string StartedAt { get; set; }
#endif
        /// <summary>The websiteId property</summary>
        public Guid? WebsiteId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.BackupStatus"/> and sets the default values.
        /// </summary>
        public BackupStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.BackupStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.BackupStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.BackupStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Enhance.Client.Models.BackupAction>(); } },
                { "emailsStatus", n => { EmailsStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "homeDirStatus", n => { HomeDirStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "mysqlDbsStatus", n => { MysqlDbsStatus = n.GetEnumValue<global::Enhance.Client.Models.OperationStatus>(); } },
                { "startedAt", n => { StartedAt = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Enhance.Client.Models.BackupAction>("action", Action);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("emailsStatus", EmailsStatus);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("homeDirStatus", HomeDirStatus);
            writer.WriteIntValue("id", Id);
            writer.WriteEnumValue<global::Enhance.Client.Models.OperationStatus>("mysqlDbsStatus", MysqlDbsStatus);
            writer.WriteStringValue("startedAt", StartedAt);
            writer.WriteGuidValue("websiteId", WebsiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618