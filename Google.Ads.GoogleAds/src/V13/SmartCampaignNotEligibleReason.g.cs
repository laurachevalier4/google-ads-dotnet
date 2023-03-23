// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/enums/smart_campaign_not_eligible_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/enums/smart_campaign_not_eligible_reason.proto</summary>
  public static partial class SmartCampaignNotEligibleReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/enums/smart_campaign_not_eligible_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SmartCampaignNotEligibleReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMvc21hcnRfY2FtcGFp",
            "Z25fbm90X2VsaWdpYmxlX3JlYXNvbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEzLmVudW1zIssBCiJTbWFydENhbXBhaWduTm90RWxpZ2libGVS",
            "ZWFzb25FbnVtIqQBCh5TbWFydENhbXBhaWduTm90RWxpZ2libGVSZWFzb24S",
            "DwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoNQUNDT1VOVF9JU1NV",
            "RRACEhEKDUJJTExJTkdfSVNTVUUQAxIlCiFCVVNJTkVTU19QUk9GSUxFX0xP",
            "Q0FUSU9OX1JFTU9WRUQQBBIXChNBTExfQURTX0RJU0FQUFJPVkVEEAVC/QEK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMuZW51bXNCI1NtYXJ0Q2Ft",
            "cGFpZ25Ob3RFbGlnaWJsZVJlYXNvblByb3RvUAFaQ2dvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMvZW51",
            "bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTMuRW51",
            "bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTNcRW51bXPqAiJHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMTM6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Enums.SmartCampaignNotEligibleReasonEnum), global::Google.Ads.GoogleAds.V13.Enums.SmartCampaignNotEligibleReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Enums.SmartCampaignNotEligibleReasonEnum.Types.SmartCampaignNotEligibleReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A container for an enum that describes reasons for why a Smart campaign
  /// is not eligible to serve.
  /// </summary>
  public sealed partial class SmartCampaignNotEligibleReasonEnum : pb::IMessage<SmartCampaignNotEligibleReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SmartCampaignNotEligibleReasonEnum> _parser = new pb::MessageParser<SmartCampaignNotEligibleReasonEnum>(() => new SmartCampaignNotEligibleReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SmartCampaignNotEligibleReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Enums.SmartCampaignNotEligibleReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignNotEligibleReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignNotEligibleReasonEnum(SmartCampaignNotEligibleReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignNotEligibleReasonEnum Clone() {
      return new SmartCampaignNotEligibleReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SmartCampaignNotEligibleReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SmartCampaignNotEligibleReasonEnum other) {
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
    public void MergeFrom(SmartCampaignNotEligibleReasonEnum other) {
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
    /// <summary>Container for nested types declared in the SmartCampaignNotEligibleReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Reasons for why a Smart campaign is not eligible to serve.
      /// </summary>
      public enum SmartCampaignNotEligibleReason {
        /// <summary>
        /// The status has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign is not eligible to serve because of an issue with the
        /// account.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_ISSUE")] AccountIssue = 2,
        /// <summary>
        /// The campaign is not eligible to serve because of a payment issue.
        /// </summary>
        [pbr::OriginalName("BILLING_ISSUE")] BillingIssue = 3,
        /// <summary>
        /// The business profile location associated with the campaign has been
        /// removed.
        /// </summary>
        [pbr::OriginalName("BUSINESS_PROFILE_LOCATION_REMOVED")] BusinessProfileLocationRemoved = 4,
        /// <summary>
        /// All system-generated ads have been disapproved. Consult the
        /// policy_summary field in the AdGroupAd resource for more details.
        /// </summary>
        [pbr::OriginalName("ALL_ADS_DISAPPROVED")] AllAdsDisapproved = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code