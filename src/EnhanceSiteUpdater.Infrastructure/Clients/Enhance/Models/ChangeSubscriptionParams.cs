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
    public partial class ChangeSubscriptionParams : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The subscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId? SubscriptionId { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId SubscriptionId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ChangeSubscriptionParams"/> and sets the default values.
        /// </summary>
        public ChangeSubscriptionParams()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ChangeSubscriptionParams"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ChangeSubscriptionParams CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ChangeSubscriptionParams();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "subscriptionId", n => { SubscriptionId = n.GetObjectValue<global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId>(global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId>("subscriptionId", SubscriptionId);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Enhance.Client.Models.Unset"/>, <see cref="int"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChangeSubscriptionParams_subscriptionId : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Enhance.Client.Models.Unset"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Enhance.Client.Models.Unset? Unset { get; set; }
#nullable restore
#else
            public global::Enhance.Client.Models.Unset Unset { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Enhance.Client.Models.ChangeSubscriptionParams.ChangeSubscriptionParams_subscriptionId();
                if("Unset".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Unset = new global::Enhance.Client.Models.Unset();
                }
                else if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(Unset != null)
                {
                    return Unset.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Unset != null)
                {
                    writer.WriteObjectValue<global::Enhance.Client.Models.Unset>(null, Unset);
                }
                else if(Integer != null)
                {
                    writer.WriteIntValue(null, Integer);
                }
            }
        }
    }
}
#pragma warning restore CS0618