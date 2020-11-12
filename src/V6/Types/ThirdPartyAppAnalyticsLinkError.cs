// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/errors/third_party_app_analytics_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/errors/third_party_app_analytics_link_error.proto</summary>
  public static partial class ThirdPartyAppAnalyticsLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/errors/third_party_app_analytics_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ThirdPartyAppAnalyticsLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lcnJvcnMvdGhpcmRfcGFydHlf",
            "YXBwX2FuYWx5dGljc19saW5rX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52Ni5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8i/gEKI1RoaXJkUGFydHlBcHBBbmFseXRpY3NMaW5rRXJyb3JFbnVtItYB",
            "Ch9UaGlyZFBhcnR5QXBwQW5hbHl0aWNzTGlua0Vycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEiEKHUlOVkFMSURfQU5BTFlUSUNTX1BST1ZJ",
            "REVSX0lEEAISGQoVSU5WQUxJRF9NT0JJTEVfQVBQX0lEEAMSHQoZTU9CSUxF",
            "X0FQUF9JU19OT1RfRU5BQkxFRBAEEjgKNENBTk5PVF9SRUdFTkVSQVRFX1NI",
            "QVJFQUJMRV9MSU5LX0lEX0ZPUl9SRU1PVkVEX0xJTksQBUL/AQoiY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnY2LmVycm9yc0IkVGhpcmRQYXJ0eUFwcEFu",
            "YWx5dGljc0xpbmtFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ni9lcnJvcnM7ZXJy",
            "b3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjYuRXJyb3JzygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjZcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjY6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Errors.ThirdPartyAppAnalyticsLinkErrorEnum), global::Google.Ads.GoogleAds.V6.Errors.ThirdPartyAppAnalyticsLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V6.Errors.ThirdPartyAppAnalyticsLinkErrorEnum.Types.ThirdPartyAppAnalyticsLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible third party app analytics link errors.
  /// </summary>
  public sealed partial class ThirdPartyAppAnalyticsLinkErrorEnum : pb::IMessage<ThirdPartyAppAnalyticsLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum> _parser = new pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum>(() => new ThirdPartyAppAnalyticsLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Errors.ThirdPartyAppAnalyticsLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThirdPartyAppAnalyticsLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThirdPartyAppAnalyticsLinkErrorEnum(ThirdPartyAppAnalyticsLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThirdPartyAppAnalyticsLinkErrorEnum Clone() {
      return new ThirdPartyAppAnalyticsLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ThirdPartyAppAnalyticsLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ThirdPartyAppAnalyticsLinkErrorEnum other) {
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ThirdPartyAppAnalyticsLinkErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    /// <summary>Container for nested types declared in the ThirdPartyAppAnalyticsLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible third party app analytics link errors.
      /// </summary>
      public enum ThirdPartyAppAnalyticsLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The provided analytics provider ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_ANALYTICS_PROVIDER_ID")] InvalidAnalyticsProviderId = 2,
        /// <summary>
        /// The provided mobile app ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_APP_ID")] InvalidMobileAppId = 3,
        /// <summary>
        /// The mobile app corresponding to the provided app ID is not
        /// active/enabled.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_IS_NOT_ENABLED")] MobileAppIsNotEnabled = 4,
        /// <summary>
        /// Regenerating shareable link ID is only allowed on active links
        /// </summary>
        [pbr::OriginalName("CANNOT_REGENERATE_SHAREABLE_LINK_ID_FOR_REMOVED_LINK")] CannotRegenerateShareableLinkIdForRemovedLink = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
