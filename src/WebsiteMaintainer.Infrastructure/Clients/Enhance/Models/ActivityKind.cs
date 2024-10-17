// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Enhance.Client.Models
{
    /// <summary>Different activities that happen in orchd. There will be a lot of changes to the values of this enum as time goes by, consider this non-exhausive and be graceful with unknown values.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ActivityKind
    {
        [EnumMember(Value = "added")]
        #pragma warning disable CS1591
        Added,
        #pragma warning restore CS1591
        [EnumMember(Value = "removed")]
        #pragma warning disable CS1591
        Removed,
        #pragma warning restore CS1591
        [EnumMember(Value = "cloned")]
        #pragma warning disable CS1591
        Cloned,
        #pragma warning restore CS1591
        [EnumMember(Value = "imported")]
        #pragma warning disable CS1591
        Imported,
        #pragma warning restore CS1591
        [EnumMember(Value = "backedUp")]
        #pragma warning disable CS1591
        BackedUp,
        #pragma warning restore CS1591
        [EnumMember(Value = "errorRaised")]
        #pragma warning disable CS1591
        ErrorRaised,
        #pragma warning restore CS1591
        [EnumMember(Value = "backupError")]
        #pragma warning disable CS1591
        BackupError,
        #pragma warning restore CS1591
    }
}