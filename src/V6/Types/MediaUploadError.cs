// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/errors/media_upload_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/errors/media_upload_error.proto</summary>
  public static partial class MediaUploadErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/errors/media_upload_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaUploadErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lcnJvcnMvbWVkaWFfdXBsb2Fk",
            "X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5lcnJvcnMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i4ggKFE1lZGlhVXBsb2Fk",
            "RXJyb3JFbnVtIskIChBNZWRpYVVwbG9hZEVycm9yEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEhAKDEZJTEVfVE9PX0JJRxACEhUKEVVOUEFSU0VB",
            "QkxFX0lNQUdFEAMSHgoaQU5JTUFURURfSU1BR0VfTk9UX0FMTE9XRUQQBBIW",
            "ChJGT1JNQVRfTk9UX0FMTE9XRUQQBRIcChhFWFRFUk5BTF9VUkxfTk9UX0FM",
            "TE9XRUQQBhIZChVJTlZBTElEX1VSTF9SRUZFUkVOQ0UQBxImCiJNSVNTSU5H",
            "X1BSSU1BUllfTUVESUFfQlVORExFX0VOVFJZEAgSGgoWQU5JTUFURURfVklT",
            "VUFMX0VGRkVDVBAJEhYKEkFOSU1BVElPTl9UT09fTE9ORxAKEhwKGEFTUEVD",
            "VF9SQVRJT19OT1RfQUxMT1dFRBALEiUKIUFVRElPX05PVF9BTExPV0VEX0lO",
            "X01FRElBX0JVTkRMRRAMEhkKFUNNWUtfSlBFR19OT1RfQUxMT1dFRBANEhUK",
            "EUZMQVNIX05PVF9BTExPV0VEEA4SFwoTRlJBTUVfUkFURV9UT09fSElHSBAP",
            "Ei4KKkdPT0dMRV9XRUJfREVTSUdORVJfWklQX0ZJTEVfTk9UX1BVQkxJU0hF",
            "RBAQEh4KGklNQUdFX0NPTlNUUkFJTlRTX1ZJT0xBVEVEEBESGAoUSU5WQUxJ",
            "RF9NRURJQV9CVU5ETEUQEhIeChpJTlZBTElEX01FRElBX0JVTkRMRV9FTlRS",
            "WRATEhUKEUlOVkFMSURfTUlNRV9UWVBFEBQSEAoMSU5WQUxJRF9QQVRIEBUS",
            "EgoOTEFZT1VUX1BST0JMRU0QFhIRCg1NQUxGT1JNRURfVVJMEBcSHAoYTUVE",
            "SUFfQlVORExFX05PVF9BTExPV0VEEBgSLworTUVESUFfQlVORExFX05PVF9D",
            "T01QQVRJQkxFX1RPX1BST0RVQ1RfVFlQRRAZEjEKLU1FRElBX0JVTkRMRV9S",
            "RUpFQ1RFRF9CWV9NVUxUSVBMRV9BU1NFVF9TUEVDUxAaEiIKHlRPT19NQU5Z",
            "X0ZJTEVTX0lOX01FRElBX0JVTkRMRRAbEi8KK1VOU1VQUE9SVEVEX0dPT0dM",
            "RV9XRUJfREVTSUdORVJfRU5WSVJPTk1FTlQQHBIdChlVTlNVUFBPUlRFRF9I",
            "VE1MNV9GRUFUVVJFEB0SKQolVVJMX0lOX01FRElBX0JVTkRMRV9OT1RfU1NM",
            "X0NPTVBMSUFOVBAeEhwKGFZJREVPX0ZJTEVfTkFNRV9UT09fTE9ORxAfEicK",
            "I1ZJREVPX01VTFRJUExFX0ZJTEVTX1dJVEhfU0FNRV9OQU1FECASJQohVklE",
            "RU9fTk9UX0FMTE9XRURfSU5fTUVESUFfQlVORExFECESKAokQ0FOTk9UX1VQ",
            "TE9BRF9NRURJQV9UWVBFX1RIUk9VR0hfQVBJECJC8AEKImNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Ni5lcnJvcnNCFU1lZGlhVXBsb2FkRXJyb3JQcm90",
            "b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjYvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlY2LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFY2XEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY2OjpFcnJv",
            "cnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Errors.MediaUploadErrorEnum), global::Google.Ads.GoogleAds.V6.Errors.MediaUploadErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V6.Errors.MediaUploadErrorEnum.Types.MediaUploadError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible media uploading errors.
  /// </summary>
  public sealed partial class MediaUploadErrorEnum : pb::IMessage<MediaUploadErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MediaUploadErrorEnum> _parser = new pb::MessageParser<MediaUploadErrorEnum>(() => new MediaUploadErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaUploadErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Errors.MediaUploadErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaUploadErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaUploadErrorEnum(MediaUploadErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaUploadErrorEnum Clone() {
      return new MediaUploadErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaUploadErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaUploadErrorEnum other) {
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
    public void MergeFrom(MediaUploadErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MediaUploadErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible media uploading errors.
      /// </summary>
      public enum MediaUploadError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The uploaded file is too big.
        /// </summary>
        [pbr::OriginalName("FILE_TOO_BIG")] FileTooBig = 2,
        /// <summary>
        /// Image data is unparseable.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_IMAGE")] UnparseableImage = 3,
        /// <summary>
        /// Animated images are not allowed.
        /// </summary>
        [pbr::OriginalName("ANIMATED_IMAGE_NOT_ALLOWED")] AnimatedImageNotAllowed = 4,
        /// <summary>
        /// The image or media bundle format is not allowed.
        /// </summary>
        [pbr::OriginalName("FORMAT_NOT_ALLOWED")] FormatNotAllowed = 5,
        /// <summary>
        /// Cannot reference URL external to the media bundle.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_URL_NOT_ALLOWED")] ExternalUrlNotAllowed = 6,
        /// <summary>
        /// HTML5 ad is trying to reference an asset not in .ZIP file.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_REFERENCE")] InvalidUrlReference = 7,
        /// <summary>
        /// The media bundle contains no primary entry.
        /// </summary>
        [pbr::OriginalName("MISSING_PRIMARY_MEDIA_BUNDLE_ENTRY")] MissingPrimaryMediaBundleEntry = 8,
        /// <summary>
        /// Animation has disallowed visual effects.
        /// </summary>
        [pbr::OriginalName("ANIMATED_VISUAL_EFFECT")] AnimatedVisualEffect = 9,
        /// <summary>
        /// Animation longer than the allowed 30 second limit.
        /// </summary>
        [pbr::OriginalName("ANIMATION_TOO_LONG")] AnimationTooLong = 10,
        /// <summary>
        /// The aspect ratio of the image does not match the expected aspect ratios
        /// provided in the asset spec.
        /// </summary>
        [pbr::OriginalName("ASPECT_RATIO_NOT_ALLOWED")] AspectRatioNotAllowed = 11,
        /// <summary>
        /// Audio files are not allowed in bundle.
        /// </summary>
        [pbr::OriginalName("AUDIO_NOT_ALLOWED_IN_MEDIA_BUNDLE")] AudioNotAllowedInMediaBundle = 12,
        /// <summary>
        /// CMYK jpegs are not supported.
        /// </summary>
        [pbr::OriginalName("CMYK_JPEG_NOT_ALLOWED")] CmykJpegNotAllowed = 13,
        /// <summary>
        /// Flash movies are not allowed.
        /// </summary>
        [pbr::OriginalName("FLASH_NOT_ALLOWED")] FlashNotAllowed = 14,
        /// <summary>
        /// The frame rate of the video is higher than the allowed 5fps.
        /// </summary>
        [pbr::OriginalName("FRAME_RATE_TOO_HIGH")] FrameRateTooHigh = 15,
        /// <summary>
        /// ZIP file from Google Web Designer is not published.
        /// </summary>
        [pbr::OriginalName("GOOGLE_WEB_DESIGNER_ZIP_FILE_NOT_PUBLISHED")] GoogleWebDesignerZipFileNotPublished = 16,
        /// <summary>
        /// Image constraints are violated, but more details (like
        /// DIMENSIONS_NOT_ALLOWED or ASPECT_RATIO_NOT_ALLOWED) can not be provided.
        /// This happens when asset spec contains more than one constraint and
        /// criteria of different constraints are violated.
        /// </summary>
        [pbr::OriginalName("IMAGE_CONSTRAINTS_VIOLATED")] ImageConstraintsViolated = 17,
        /// <summary>
        /// Media bundle data is unrecognizable.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE")] InvalidMediaBundle = 18,
        /// <summary>
        /// There was a problem with one or more of the media bundle entries.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE_ENTRY")] InvalidMediaBundleEntry = 19,
        /// <summary>
        /// The asset has an invalid mime type.
        /// </summary>
        [pbr::OriginalName("INVALID_MIME_TYPE")] InvalidMimeType = 20,
        /// <summary>
        /// The media bundle contains an invalid asset path.
        /// </summary>
        [pbr::OriginalName("INVALID_PATH")] InvalidPath = 21,
        /// <summary>
        /// Image has layout problem.
        /// </summary>
        [pbr::OriginalName("LAYOUT_PROBLEM")] LayoutProblem = 22,
        /// <summary>
        /// An asset had a URL reference that is malformed per RFC 1738 convention.
        /// </summary>
        [pbr::OriginalName("MALFORMED_URL")] MalformedUrl = 23,
        /// <summary>
        /// The uploaded media bundle format is not allowed.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_NOT_ALLOWED")] MediaBundleNotAllowed = 24,
        /// <summary>
        /// The media bundle is not compatible with the asset spec product type.
        /// (E.g. Gmail, dynamic remarketing, etc.)
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_NOT_COMPATIBLE_TO_PRODUCT_TYPE")] MediaBundleNotCompatibleToProductType = 25,
        /// <summary>
        /// A bundle being uploaded that is incompatible with multiple assets for
        /// different reasons.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_REJECTED_BY_MULTIPLE_ASSET_SPECS")] MediaBundleRejectedByMultipleAssetSpecs = 26,
        /// <summary>
        /// The media bundle contains too many files.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_FILES_IN_MEDIA_BUNDLE")] TooManyFilesInMediaBundle = 27,
        /// <summary>
        /// Google Web Designer not created for "Google Ads" environment.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_GOOGLE_WEB_DESIGNER_ENVIRONMENT")] UnsupportedGoogleWebDesignerEnvironment = 28,
        /// <summary>
        /// Unsupported HTML5 feature in HTML5 asset.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_HTML5_FEATURE")] UnsupportedHtml5Feature = 29,
        /// <summary>
        /// URL in HTML5 entry is not SSL compliant.
        /// </summary>
        [pbr::OriginalName("URL_IN_MEDIA_BUNDLE_NOT_SSL_COMPLIANT")] UrlInMediaBundleNotSslCompliant = 30,
        /// <summary>
        /// Video file name is longer than the 50 allowed characters.
        /// </summary>
        [pbr::OriginalName("VIDEO_FILE_NAME_TOO_LONG")] VideoFileNameTooLong = 31,
        /// <summary>
        /// Multiple videos with same name in a bundle.
        /// </summary>
        [pbr::OriginalName("VIDEO_MULTIPLE_FILES_WITH_SAME_NAME")] VideoMultipleFilesWithSameName = 32,
        /// <summary>
        /// Videos are not allowed in media bundle.
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_ALLOWED_IN_MEDIA_BUNDLE")] VideoNotAllowedInMediaBundle = 33,
        /// <summary>
        /// This type of media cannot be uploaded through the Google Ads API.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPLOAD_MEDIA_TYPE_THROUGH_API")] CannotUploadMediaTypeThroughApi = 34,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
