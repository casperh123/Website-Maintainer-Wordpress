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
    public partial class MigrationSessionDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The migrationsCount property</summary>
        public int? MigrationsCount { get; set; }
        /// <summary>The notReadyCount property</summary>
        public int? NotReadyCount { get; set; }
        /// <summary>The percentageComplete property</summary>
        public double? PercentageComplete { get; set; }
        /// <summary>The updatedAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.MigrationSessionDetails"/> and sets the default values.
        /// </summary>
        public MigrationSessionDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.MigrationSessionDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.MigrationSessionDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.MigrationSessionDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdAt", n => { CreatedAt = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "migrationsCount", n => { MigrationsCount = n.GetIntValue(); } },
                { "notReadyCount", n => { NotReadyCount = n.GetIntValue(); } },
                { "percentageComplete", n => { PercentageComplete = n.GetDoubleValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createdAt", CreatedAt);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteGuidValue("id", Id);
            writer.WriteIntValue("migrationsCount", MigrationsCount);
            writer.WriteIntValue("notReadyCount", NotReadyCount);
            writer.WriteDoubleValue("percentageComplete", PercentageComplete);
            writer.WriteStringValue("updatedAt", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618