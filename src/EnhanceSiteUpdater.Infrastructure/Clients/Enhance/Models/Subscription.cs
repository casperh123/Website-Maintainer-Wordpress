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
    /// An organization&apos;s subscription to a plan. This allows the subscriber to use the subscribed to resources up until the quota defined in the plan is exhausted. Includes details about the subscription as well as the current usage of the resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Subscription : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allowances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.Allowance>? Allowances { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.Allowance> Allowances { get; set; }
#endif
        /// <summary>The allowedPhpVersions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.PhpVersion?>? AllowedPhpVersions { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.PhpVersion?> AllowedPhpVersions { get; set; }
#endif
        /// <summary>The dedicatedServers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.SubscriptionDedicatedServersInfo? DedicatedServers { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.SubscriptionDedicatedServersInfo DedicatedServers { get; set; }
#endif
        /// <summary>The defaultPhpVersion property</summary>
        public global::Enhance.Client.Models.PhpVersion? DefaultPhpVersion { get; set; }
        /// <summary>The friendlyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The planId property</summary>
        public int? PlanId { get; set; }
        /// <summary>The planName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlanName { get; set; }
#nullable restore
#else
        public string PlanName { get; set; }
#endif
        /// <summary>The planType property</summary>
        public global::Enhance.Client.Models.PlanType? PlanType { get; set; }
        /// <summary>:&gt; When WordPress is installed on a website under this plan, the chosen theme will be preinstalled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreinstallWordpressTheme { get; set; }
#nullable restore
#else
        public string PreinstallWordpressTheme { get; set; }
#endif
        /// <summary>The redisAllowed property</summary>
        public bool? RedisAllowed { get; set; }
        /// <summary>A list of used resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.UsedResource>? Resources { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.UsedResource> Resources { get; set; }
#endif
        /// <summary>The selections property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.Selection>? Selections { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.Selection> Selections { get; set; }
#endif
        /// <summary>If this field is present, the customer is allowed to chose from the server groups listed here when creating a website.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ServerGroup>? ServerGroups { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ServerGroup> ServerGroups { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::Enhance.Client.Models.Status? Status { get; set; }
        /// <summary>The subscriberId property</summary>
        public Guid? SubscriberId { get; set; }
        /// <summary>The suspendedBy property</summary>
        public Guid? SuspendedBy { get; set; }
        /// <summary>The vendorId property</summary>
        public Guid? VendorId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.Subscription"/> and sets the default values.
        /// </summary>
        public Subscription()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.Subscription"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.Subscription CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.Subscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowances", n => { Allowances = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.Allowance>(global::Enhance.Client.Models.Allowance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "allowedPhpVersions", n => { AllowedPhpVersions = n.GetCollectionOfEnumValues<global::Enhance.Client.Models.PhpVersion>()?.AsList(); } },
                { "dedicatedServers", n => { DedicatedServers = n.GetObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServersInfo>(global::Enhance.Client.Models.SubscriptionDedicatedServersInfo.CreateFromDiscriminatorValue); } },
                { "defaultPhpVersion", n => { DefaultPhpVersion = n.GetEnumValue<global::Enhance.Client.Models.PhpVersion>(); } },
                { "friendlyName", n => { FriendlyName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "planId", n => { PlanId = n.GetIntValue(); } },
                { "planName", n => { PlanName = n.GetStringValue(); } },
                { "planType", n => { PlanType = n.GetEnumValue<global::Enhance.Client.Models.PlanType>(); } },
                { "preinstallWordpressTheme", n => { PreinstallWordpressTheme = n.GetStringValue(); } },
                { "redisAllowed", n => { RedisAllowed = n.GetBoolValue(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.UsedResource>(global::Enhance.Client.Models.UsedResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "selections", n => { Selections = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.Selection>(global::Enhance.Client.Models.Selection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "serverGroups", n => { ServerGroups = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ServerGroup>(global::Enhance.Client.Models.ServerGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Enhance.Client.Models.Status>(); } },
                { "subscriberId", n => { SubscriberId = n.GetGuidValue(); } },
                { "suspendedBy", n => { SuspendedBy = n.GetGuidValue(); } },
                { "vendorId", n => { VendorId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.Allowance>("allowances", Allowances);
            writer.WriteCollectionOfEnumValues<global::Enhance.Client.Models.PhpVersion>("allowedPhpVersions", AllowedPhpVersions);
            writer.WriteObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServersInfo>("dedicatedServers", DedicatedServers);
            writer.WriteEnumValue<global::Enhance.Client.Models.PhpVersion>("defaultPhpVersion", DefaultPhpVersion);
            writer.WriteStringValue("friendlyName", FriendlyName);
            writer.WriteIntValue("id", Id);
            writer.WriteIntValue("planId", PlanId);
            writer.WriteStringValue("planName", PlanName);
            writer.WriteEnumValue<global::Enhance.Client.Models.PlanType>("planType", PlanType);
            writer.WriteStringValue("preinstallWordpressTheme", PreinstallWordpressTheme);
            writer.WriteBoolValue("redisAllowed", RedisAllowed);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.UsedResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.Selection>("selections", Selections);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ServerGroup>("serverGroups", ServerGroups);
            writer.WriteEnumValue<global::Enhance.Client.Models.Status>("status", Status);
            writer.WriteGuidValue("subscriberId", SubscriberId);
            writer.WriteGuidValue("suspendedBy", SuspendedBy);
            writer.WriteGuidValue("vendorId", VendorId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618