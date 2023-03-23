// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/policy_approval_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/policy_approval_status.proto</summary>
  public static partial class PolicyApprovalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/policy_approval_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyApprovalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvcG9saWN5X2FwcHJv",
            "dmFsX3N0YXR1cy5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmVu",
            "dW1zIqEBChhQb2xpY3lBcHByb3ZhbFN0YXR1c0VudW0ihAEKFFBvbGljeUFw",
            "cHJvdmFsU3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEg8K",
            "C0RJU0FQUFJPVkVEEAISFAoQQVBQUk9WRURfTElNSVRFRBADEgwKCEFQUFJP",
            "VkVEEAQSGQoVQVJFQV9PRl9JTlRFUkVTVF9PTkxZEAVC8wEKImNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXNCGVBvbGljeUFwcHJvdmFsU3Rh",
            "dHVzUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxMi9lbnVtcztlbnVtc6ICA0dBQaoCHkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxMi5FbnVtc8oCHkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxMlxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "Mjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.PolicyApprovalStatusEnum), global::Google.Ads.GoogleAds.V12.Enums.PolicyApprovalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy approval statuses.
  /// </summary>
  public sealed partial class PolicyApprovalStatusEnum : pb::IMessage<PolicyApprovalStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyApprovalStatusEnum> _parser = new pb::MessageParser<PolicyApprovalStatusEnum>(() => new PolicyApprovalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PolicyApprovalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.PolicyApprovalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyApprovalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyApprovalStatusEnum(PolicyApprovalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyApprovalStatusEnum Clone() {
      return new PolicyApprovalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PolicyApprovalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PolicyApprovalStatusEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PolicyApprovalStatusEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PolicyApprovalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible policy approval statuses. When there are several approval
      /// statuses available the most severe one will be used. The order of severity
      /// is DISAPPROVED, AREA_OF_INTEREST_ONLY, APPROVED_LIMITED and APPROVED.
      /// </summary>
      public enum PolicyApprovalStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Will not serve.
        /// </summary>
        [pbr::OriginalName("DISAPPROVED")] Disapproved = 2,
        /// <summary>
        /// Serves with restrictions.
        /// </summary>
        [pbr::OriginalName("APPROVED_LIMITED")] ApprovedLimited = 3,
        /// <summary>
        /// Serves without restrictions.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 4,
        /// <summary>
        /// Will not serve in targeted countries, but may serve for users who are
        /// searching for information about the targeted countries.
        /// </summary>
        [pbr::OriginalName("AREA_OF_INTEREST_ONLY")] AreaOfInterestOnly = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code