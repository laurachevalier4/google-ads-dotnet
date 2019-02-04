// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/user_list_logical_rule_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/user_list_logical_rule_operator.proto</summary>
  public static partial class UserListLogicalRuleOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/user_list_logical_rule_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListLogicalRuleOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy91c2VyX2xpc3RfbG9n",
            "aWNhbF9ydWxlX29wZXJhdG9yLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MC5lbnVtcyJ6Ch9Vc2VyTGlzdExvZ2ljYWxSdWxlT3BlcmF0b3JFbnVt",
            "IlcKG1VzZXJMaXN0TG9naWNhbFJ1bGVPcGVyYXRvchIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIHCgNBTEwQAhIHCgNBTlkQAxIICgROT05FEARC",
            "9QEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IgVXNlckxp",
            "c3RMb2dpY2FsUnVsZU9wZXJhdG9yUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1z",
            "O2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPK",
            "Ah1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxFbnVtc+oCIUdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListLogicalRuleOperatorEnum), global::Google.Ads.GoogleAds.V0.Enums.UserListLogicalRuleOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListLogicalRuleOperatorEnum.Types.UserListLogicalRuleOperator) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The logical operator of the rule.
  /// </summary>
  public sealed partial class UserListLogicalRuleOperatorEnum : pb::IMessage<UserListLogicalRuleOperatorEnum> {
    private static readonly pb::MessageParser<UserListLogicalRuleOperatorEnum> _parser = new pb::MessageParser<UserListLogicalRuleOperatorEnum>(() => new UserListLogicalRuleOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListLogicalRuleOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.UserListLogicalRuleOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum(UserListLogicalRuleOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum Clone() {
      return new UserListLogicalRuleOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListLogicalRuleOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListLogicalRuleOperatorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserListLogicalRuleOperatorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UserListLogicalRuleOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list logical rule operators.
      /// </summary>
      public enum UserListLogicalRuleOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// And - all of the operands.
        /// </summary>
        [pbr::OriginalName("ALL")] All = 2,
        /// <summary>
        /// Or - at least one of the operands.
        /// </summary>
        [pbr::OriginalName("ANY")] Any = 3,
        /// <summary>
        /// Not - none of the operands.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
