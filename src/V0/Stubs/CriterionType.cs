// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/criterion_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/criterion_type.proto</summary>
  public static partial class CriterionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/criterion_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jcml0ZXJpb25fdHlw",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMi7QMKEUNy",
            "aXRlcmlvblR5cGVFbnVtItcDCg1Dcml0ZXJpb25UeXBlEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEgsKB0tFWVdPUkQQAhINCglQTEFDRU1FTlQQ",
            "AxIXChNNT0JJTEVfQVBQX0NBVEVHT1JZEAQSCgoGREVWSUNFEAYSDAoITE9D",
            "QVRJT04QBxIRCg1MSVNUSU5HX0dST1VQEAgSDwoLQURfU0NIRURVTEUQCRIN",
            "CglBR0VfUkFOR0UQChIKCgZHRU5ERVIQCxIQCgxJTkNPTUVfUkFOR0UQDBIT",
            "Cg9QQVJFTlRBTF9TVEFUVVMQDRIRCg1ZT1VUVUJFX1ZJREVPEA4SEwoPWU9V",
            "VFVCRV9DSEFOTkVMEA8SDQoJVVNFUl9MSVNUEBASDQoJUFJPWElNSVRZEBES",
            "CQoFVE9QSUMQEhIRCg1MSVNUSU5HX1NDT1BFEBMSDAoITEFOR1VBR0UQFBIM",
            "CghJUF9CTE9DSxAVEhEKDUNPTlRFTlRfTEFCRUwQFhILCgdDQVJSSUVSEBcS",
            "EQoNVVNFUl9JTlRFUkVTVBAYEgsKB1dFQlBBR0UQGRIcChhPUEVSQVRJTkdf",
            "U1lTVEVNX1ZFUlNJT04QGhIVChFBUFBfUEFZTUVOVF9NT0RFTBAbQucBCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXNCEkNyaXRlcmlvblR5",
            "cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYwXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjA6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeEnum.Types.CriterionType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The possible types of a criterion.
  /// </summary>
  public sealed partial class CriterionTypeEnum : pb::IMessage<CriterionTypeEnum> {
    private static readonly pb::MessageParser<CriterionTypeEnum> _parser = new pb::MessageParser<CriterionTypeEnum>(() => new CriterionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.CriterionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum(CriterionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum Clone() {
      return new CriterionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionTypeEnum other) {
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
    public void MergeFrom(CriterionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible criterion types.
      /// </summary>
      public enum CriterionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword. e.g. 'mars cruise'.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 2,
        /// <summary>
        /// Placement, aka Website. e.g. 'www.flowers4sale.com'
        /// </summary>
        [pbr::OriginalName("PLACEMENT")] Placement = 3,
        /// <summary>
        /// Mobile application categories to target.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_CATEGORY")] MobileAppCategory = 4,
        /// <summary>
        /// Devices to target.
        /// </summary>
        [pbr::OriginalName("DEVICE")] Device = 6,
        /// <summary>
        /// Locations to target.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 7,
        /// <summary>
        /// Listing groups to target.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP")] ListingGroup = 8,
        /// <summary>
        /// Ad Schedule.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE")] AdSchedule = 9,
        /// <summary>
        /// Age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 10,
        /// <summary>
        /// Gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 11,
        /// <summary>
        /// Income Range.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 12,
        /// <summary>
        /// Parental status.
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 13,
        /// <summary>
        /// YouTube Video.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 14,
        /// <summary>
        /// YouTube Channel.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_CHANNEL")] YoutubeChannel = 15,
        /// <summary>
        /// User list.
        /// </summary>
        [pbr::OriginalName("USER_LIST")] UserList = 16,
        /// <summary>
        /// Proximity.
        /// </summary>
        [pbr::OriginalName("PROXIMITY")] Proximity = 17,
        /// <summary>
        /// A topic target on the display network (e.g. "Pets &amp; Animals").
        /// </summary>
        [pbr::OriginalName("TOPIC")] Topic = 18,
        /// <summary>
        /// Listing scope to target.
        /// </summary>
        [pbr::OriginalName("LISTING_SCOPE")] ListingScope = 19,
        /// <summary>
        /// Language.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 20,
        /// <summary>
        /// IpBlock.
        /// </summary>
        [pbr::OriginalName("IP_BLOCK")] IpBlock = 21,
        /// <summary>
        /// Content Label for category exclusion.
        /// </summary>
        [pbr::OriginalName("CONTENT_LABEL")] ContentLabel = 22,
        /// <summary>
        /// Carrier.
        /// </summary>
        [pbr::OriginalName("CARRIER")] Carrier = 23,
        /// <summary>
        /// A category the user is interested in.
        /// </summary>
        [pbr::OriginalName("USER_INTEREST")] UserInterest = 24,
        /// <summary>
        /// Webpage criterion for dynamic search ads.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 25,
        /// <summary>
        /// Operating system version.
        /// </summary>
        [pbr::OriginalName("OPERATING_SYSTEM_VERSION")] OperatingSystemVersion = 26,
        /// <summary>
        /// App payment model.
        /// </summary>
        [pbr::OriginalName("APP_PAYMENT_MODEL")] AppPaymentModel = 27,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
