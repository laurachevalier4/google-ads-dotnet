// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/errors/asset_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/errors/asset_link_error.proto</summary>
  public static partial class AssetLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/errors/asset_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lcnJvcnMvYXNzZXRfbGlua19l",
            "cnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjguZXJyb3JzGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpoFChJBc3NldExpbmtFcnJv",
            "ckVudW0igwUKDkFzc2V0TGlua0Vycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEhcKE1BJTk5JTkdfVU5TVVBQT1JURUQQAhIaChZVTlNVUFBP",
            "UlRFRF9GSUVMRF9UWVBFEAMSKwonRklFTERfVFlQRV9JTkNPTVBBVElCTEVf",
            "V0lUSF9BU1NFVF9UWVBFEAQSLgoqRklFTERfVFlQRV9JTkNPTVBBVElCTEVf",
            "V0lUSF9DQU1QQUlHTl9UWVBFEAUSKQolSU5DT01QQVRJQkxFX0FEVkVSVElT",
            "SU5HX0NIQU5ORUxfVFlQRRAGEi4KKklNQUdFX05PVF9XSVRISU5fU1BFQ0lG",
            "SUVEX0RJTUVOU0lPTl9SQU5HRRAHEhgKFElOVkFMSURfUElOTkVEX0ZJRUxE",
            "EAgSKgomTUVESUFfQlVORExFX0FTU0VUX0ZJTEVfU0laRV9UT09fTEFSR0UQ",
            "CRI6CjZOT1RfRU5PVUdIX0FWQUlMQUJMRV9BU1NFVF9MSU5LU19GT1JfVkFM",
            "SURfQ09NQklOQVRJT04QChIyCi5OT1RfRU5PVUdIX0FWQUlMQUJMRV9BU1NF",
            "VF9MSU5LU19XSVRIX0ZBTExCQUNLEAsSSApETk9UX0VOT1VHSF9BVkFJTEFC",
            "TEVfQVNTRVRfTElOS1NfV0lUSF9GQUxMQkFDS19GT1JfVkFMSURfQ09NQklO",
            "QVRJT04QDBIZChVZT1VUVUJFX1ZJREVPX1JFTU9WRUQQDRIaChZZT1VUVUJF",
            "X1ZJREVPX1RPT19MT05HEA4SGwoXWU9VVFVCRV9WSURFT19UT09fU0hPUlQQ",
            "DxISCg5JTlZBTElEX1NUQVRVUxARQu4BCiJjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjguZXJyb3JzQhNBc3NldExpbmtFcnJvclByb3RvUAFaRGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92OC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjguRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjhcRXJyb3Jz",
            "6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Errors.AssetLinkErrorEnum), global::Google.Ads.GoogleAds.V8.Errors.AssetLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Errors.AssetLinkErrorEnum.Types.AssetLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset link errors.
  /// </summary>
  public sealed partial class AssetLinkErrorEnum : pb::IMessage<AssetLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetLinkErrorEnum> _parser = new pb::MessageParser<AssetLinkErrorEnum>(() => new AssetLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssetLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Errors.AssetLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetLinkErrorEnum(AssetLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetLinkErrorEnum Clone() {
      return new AssetLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssetLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssetLinkErrorEnum other) {
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
    public void MergeFrom(AssetLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset link errors.
      /// </summary>
      public enum AssetLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Pinning is not supported for the given asset link field.
        /// </summary>
        [pbr::OriginalName("PINNING_UNSUPPORTED")] PinningUnsupported = 2,
        /// <summary>
        /// The given field type is not supported to be added directly via asset
        /// links.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_FIELD_TYPE")] UnsupportedFieldType = 3,
        /// <summary>
        /// The given asset's type and the specified field type are incompatible.
        /// </summary>
        [pbr::OriginalName("FIELD_TYPE_INCOMPATIBLE_WITH_ASSET_TYPE")] FieldTypeIncompatibleWithAssetType = 4,
        /// <summary>
        /// The specified field type is incompatible with the given campaign type.
        /// </summary>
        [pbr::OriginalName("FIELD_TYPE_INCOMPATIBLE_WITH_CAMPAIGN_TYPE")] FieldTypeIncompatibleWithCampaignType = 5,
        /// <summary>
        /// The campaign advertising channel type cannot be associated with the given
        /// asset due to channel-based restrictions on the asset's fields.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_ADVERTISING_CHANNEL_TYPE")] IncompatibleAdvertisingChannelType = 6,
        /// <summary>
        /// The image asset provided is not within the dimension constraints
        /// specified for the submitted asset field.
        /// </summary>
        [pbr::OriginalName("IMAGE_NOT_WITHIN_SPECIFIED_DIMENSION_RANGE")] ImageNotWithinSpecifiedDimensionRange = 7,
        /// <summary>
        /// The pinned field is not valid for the submitted asset field.
        /// </summary>
        [pbr::OriginalName("INVALID_PINNED_FIELD")] InvalidPinnedField = 8,
        /// <summary>
        /// The media bundle asset provided is too large for the submitted asset
        /// field.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_ASSET_FILE_SIZE_TOO_LARGE")] MediaBundleAssetFileSizeTooLarge = 9,
        /// <summary>
        /// Not enough assets are available for use with other fields since other
        /// assets are pinned to specific fields.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_AVAILABLE_ASSET_LINKS_FOR_VALID_COMBINATION")] NotEnoughAvailableAssetLinksForValidCombination = 10,
        /// <summary>
        /// Not enough assets with fallback are available. When validating the
        /// minimum number of assets, assets without fallback (e.g. assets that
        /// contain location tag without default value "{LOCATION(City)}") will not
        /// be counted.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_AVAILABLE_ASSET_LINKS_WITH_FALLBACK")] NotEnoughAvailableAssetLinksWithFallback = 11,
        /// <summary>
        /// This is a combination of the
        /// NOT_ENOUGH_AVAILABLE_ASSET_LINKS_FOR_VALID_COMBINATION and
        /// NOT_ENOUGH_AVAILABLE_ASSET_LINKS_WITH_FALLBACK errors. Not enough assets
        /// with fallback are available since some assets are pinned.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_AVAILABLE_ASSET_LINKS_WITH_FALLBACK_FOR_VALID_COMBINATION")] NotEnoughAvailableAssetLinksWithFallbackForValidCombination = 12,
        /// <summary>
        /// The YouTube video referenced in the provided asset has been removed.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO_REMOVED")] YoutubeVideoRemoved = 13,
        /// <summary>
        /// The YouTube video referenced in the provided asset is too long for the
        /// field submitted.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO_TOO_LONG")] YoutubeVideoTooLong = 14,
        /// <summary>
        /// The YouTube video referenced in the provided asset is too short for the
        /// field submitted.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO_TOO_SHORT")] YoutubeVideoTooShort = 15,
        /// <summary>
        /// The status is invalid for the operation specified.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS")] InvalidStatus = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
