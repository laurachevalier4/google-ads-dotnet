// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/asset_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/asset_error.proto</summary>
  public static partial class AssetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/asset_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL2Fzc2V0X2Vycm9y",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMuZXJyb3JzIrULCg5B",
            "c3NldEVycm9yRW51bSKiCwoKQXNzZXRFcnJvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIsCihDVVNUT01FUl9OT1RfT05fQUxMT1dMSVNUX0ZP",
            "Ul9BU1NFVF9UWVBFEA0SEwoPRFVQTElDQVRFX0FTU0VUEAMSGAoURFVQTElD",
            "QVRFX0FTU0VUX05BTUUQBBIZChVBU1NFVF9EQVRBX0lTX01JU1NJTkcQBRIc",
            "ChhDQU5OT1RfTU9ESUZZX0FTU0VUX05BTUUQBhImCiJGSUVMRF9JTkNPTVBB",
            "VElCTEVfV0lUSF9BU1NFVF9UWVBFEAcSHwobSU5WQUxJRF9DQUxMX1RPX0FD",
            "VElPTl9URVhUEAgSKAokTEVBRF9GT1JNX0lOVkFMSURfRklFTERTX0NPTUJJ",
            "TkFUSU9OEAkSHwobTEVBRF9GT1JNX01JU1NJTkdfQUdSRUVNRU5UEAoSGAoU",
            "SU5WQUxJRF9BU1NFVF9TVEFUVVMQCxIrCidGSUVMRF9DQU5OT1RfQkVfTU9E",
            "SUZJRURfRk9SX0FTU0VUX1RZUEUQDBIcChhTQ0hFRFVMRVNfQ0FOTk9UX09W",
            "RVJMQVAQDhI5CjVQUk9NT1RJT05fQ0FOTk9UX1NFVF9QRVJDRU5UX09GRl9B",
            "TkRfTU9ORVlfQU1PVU5UX09GRhAPEj4KOlBST01PVElPTl9DQU5OT1RfU0VU",
            "X1BST01PVElPTl9DT0RFX0FORF9PUkRFUlNfT1ZFUl9BTU9VTlQQEBIlCiFU",
            "T09fTUFOWV9ERUNJTUFMX1BMQUNFU19TUEVDSUZJRUQQERIvCitEVVBMSUNB",
            "VEVfQVNTRVRTX1dJVEhfRElGRkVSRU5UX0ZJRUxEX1ZBTFVFEBISMgouQ0FM",
            "TF9DQVJSSUVSX1NQRUNJRklDX1NIT1JUX05VTUJFUl9OT1RfQUxMT1dFRBAT",
            "EjUKMUNBTExfQ1VTVE9NRVJfQ09OU0VOVF9GT1JfQ0FMTF9SRUNPUkRJTkdf",
            "UkVRVUlSRUQQFBIfChtDQUxMX0RJU0FMTE9XRURfTlVNQkVSX1RZUEUQFRIi",
            "Ch5DQUxMX0lOVkFMSURfQ09OVkVSU0lPTl9BQ1RJT04QFhIdChlDQUxMX0lO",
            "VkFMSURfQ09VTlRSWV9DT0RFEBcSLQopQ0FMTF9JTlZBTElEX0RPTUVTVElD",
            "X1BIT05FX05VTUJFUl9GT1JNQVQQGBIdChlDQUxMX0lOVkFMSURfUEhPTkVf",
            "TlVNQkVSEBkSLworQ0FMTF9QSE9ORV9OVU1CRVJfTk9UX1NVUFBPUlRFRF9G",
            "T1JfQ09VTlRSWRAaEigKJENBTExfUFJFTUlVTV9SQVRFX05VTUJFUl9OT1Rf",
            "QUxMT1dFRBAbEigKJENBTExfVkFOSVRZX1BIT05FX05VTUJFUl9OT1RfQUxM",
            "T1dFRBAcEiQKIFBSSUNFX0hFQURFUl9TQU1FX0FTX0RFU0NSSVBUSU9OEB0S",
            "HQoZTU9CSUxFX0FQUF9JTlZBTElEX0FQUF9JRBAeEjUKMU1PQklMRV9BUFBf",
            "SU5WQUxJRF9GSU5BTF9VUkxfRk9SX0FQUF9ET1dOTE9BRF9VUkwQHxIgChxO",
            "QU1FX1JFUVVJUkVEX0ZPUl9BU1NFVF9UWVBFECASNAowTEVBRF9GT1JNX0xF",
            "R0FDWV9RVUFMSUZZSU5HX1FVRVNUSU9OU19ESVNBTExPV0VEECESIAocTkFN",
            "RV9DT05GTElDVF9GT1JfQVNTRVRfVFlQRRAiEh4KGkNBTk5PVF9NT0RJRllf",
            "QVNTRVRfU09VUkNFECMSLQopQ0FOTk9UX01PRElGWV9BVVRPTUFUSUNBTExZ",
            "X0NSRUFURURfQVNTRVQQJBItCilMRUFEX0ZPUk1fTE9DQVRJT05fQU5TV0VS",
            "X1RZUEVfRElTQUxMT1dFRBAlQu8BCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEzLmVycm9yc0IPQXNzZXRFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "My5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTNcRXJyb3Jz6gIj",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEzOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.AssetErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.AssetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.AssetErrorEnum.Types.AssetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset errors.
  /// </summary>
  public sealed partial class AssetErrorEnum : pb::IMessage<AssetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetErrorEnum> _parser = new pb::MessageParser<AssetErrorEnum>(() => new AssetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.AssetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetErrorEnum(AssetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetErrorEnum Clone() {
      return new AssetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetErrorEnum other) {
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
    public void MergeFrom(AssetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset errors.
      /// </summary>
      public enum AssetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The customer is not is not on the allow-list for this asset type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ON_ALLOWLIST_FOR_ASSET_TYPE")] CustomerNotOnAllowlistForAssetType = 13,
        /// <summary>
        /// Assets are duplicated across operations.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSET")] DuplicateAsset = 3,
        /// <summary>
        /// The asset name is duplicated, either across operations or with an
        /// existing asset.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSET_NAME")] DuplicateAssetName = 4,
        /// <summary>
        /// The Asset.asset_data oneof is empty.
        /// </summary>
        [pbr::OriginalName("ASSET_DATA_IS_MISSING")] AssetDataIsMissing = 5,
        /// <summary>
        /// The asset has a name which is different from an existing duplicate that
        /// represents the same content.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_ASSET_NAME")] CannotModifyAssetName = 6,
        /// <summary>
        /// The field cannot be set for this asset type.
        /// </summary>
        [pbr::OriginalName("FIELD_INCOMPATIBLE_WITH_ASSET_TYPE")] FieldIncompatibleWithAssetType = 7,
        /// <summary>
        /// Call to action must come from the list of supported values.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_TO_ACTION_TEXT")] InvalidCallToActionText = 8,
        /// <summary>
        /// A lead form asset is created with an invalid combination of input fields.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_INVALID_FIELDS_COMBINATION")] LeadFormInvalidFieldsCombination = 9,
        /// <summary>
        /// Lead forms require that the Terms of Service have been agreed to before
        /// mutates can be executed.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_MISSING_AGREEMENT")] LeadFormMissingAgreement = 10,
        /// <summary>
        /// Asset status is invalid in this operation.
        /// </summary>
        [pbr::OriginalName("INVALID_ASSET_STATUS")] InvalidAssetStatus = 11,
        /// <summary>
        /// The field cannot be modified by this asset type.
        /// </summary>
        [pbr::OriginalName("FIELD_CANNOT_BE_MODIFIED_FOR_ASSET_TYPE")] FieldCannotBeModifiedForAssetType = 12,
        /// <summary>
        /// Ad schedules for the same asset cannot overlap.
        /// </summary>
        [pbr::OriginalName("SCHEDULES_CANNOT_OVERLAP")] SchedulesCannotOverlap = 14,
        /// <summary>
        /// Cannot set both percent off and money amount off fields of promotion
        /// asset.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PERCENT_OFF_AND_MONEY_AMOUNT_OFF")] PromotionCannotSetPercentOffAndMoneyAmountOff = 15,
        /// <summary>
        /// Cannot set both promotion code and orders over amount fields of promotion
        /// asset.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PROMOTION_CODE_AND_ORDERS_OVER_AMOUNT")] PromotionCannotSetPromotionCodeAndOrdersOverAmount = 16,
        /// <summary>
        /// The field has too many decimal places specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 17,
        /// <summary>
        /// Duplicate assets across operations, which have identical Asset.asset_data
        /// oneof, cannot have different asset level fields for asset types which are
        /// deduped.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSETS_WITH_DIFFERENT_FIELD_VALUE")] DuplicateAssetsWithDifferentFieldValue = 18,
        /// <summary>
        /// Carrier specific short number is not allowed.
        /// </summary>
        [pbr::OriginalName("CALL_CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CallCarrierSpecificShortNumberNotAllowed = 19,
        /// <summary>
        /// Customer consent required for call recording Terms of Service.
        /// </summary>
        [pbr::OriginalName("CALL_CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CallCustomerConsentForCallRecordingRequired = 20,
        /// <summary>
        /// The type of the specified phone number is not allowed.
        /// </summary>
        [pbr::OriginalName("CALL_DISALLOWED_NUMBER_TYPE")] CallDisallowedNumberType = 21,
        /// <summary>
        /// If the default call_conversion_action is not used, the customer must have
        /// a ConversionAction with the same id and the ConversionAction must be call
        /// conversion type.
        /// </summary>
        [pbr::OriginalName("CALL_INVALID_CONVERSION_ACTION")] CallInvalidConversionAction = 22,
        /// <summary>
        /// The country code of the phone number is invalid.
        /// </summary>
        [pbr::OriginalName("CALL_INVALID_COUNTRY_CODE")] CallInvalidCountryCode = 23,
        /// <summary>
        /// The format of the phone number is incorrect.
        /// </summary>
        [pbr::OriginalName("CALL_INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] CallInvalidDomesticPhoneNumberFormat = 24,
        /// <summary>
        /// The input phone number is not a valid phone number.
        /// </summary>
        [pbr::OriginalName("CALL_INVALID_PHONE_NUMBER")] CallInvalidPhoneNumber = 25,
        /// <summary>
        /// The phone number is not supported for country.
        /// </summary>
        [pbr::OriginalName("CALL_PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] CallPhoneNumberNotSupportedForCountry = 26,
        /// <summary>
        /// Premium rate phone number is not allowed.
        /// </summary>
        [pbr::OriginalName("CALL_PREMIUM_RATE_NUMBER_NOT_ALLOWED")] CallPremiumRateNumberNotAllowed = 27,
        /// <summary>
        /// Vanity phone number is not allowed.
        /// </summary>
        [pbr::OriginalName("CALL_VANITY_PHONE_NUMBER_NOT_ALLOWED")] CallVanityPhoneNumberNotAllowed = 28,
        /// <summary>
        /// PriceOffering cannot have the same value for header and description.
        /// </summary>
        [pbr::OriginalName("PRICE_HEADER_SAME_AS_DESCRIPTION")] PriceHeaderSameAsDescription = 29,
        /// <summary>
        /// AppId is invalid.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_INVALID_APP_ID")] MobileAppInvalidAppId = 30,
        /// <summary>
        /// Invalid App download URL in final URLs.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_INVALID_FINAL_URL_FOR_APP_DOWNLOAD_URL")] MobileAppInvalidFinalUrlForAppDownloadUrl = 31,
        /// <summary>
        /// Asset name is required for the asset type.
        /// </summary>
        [pbr::OriginalName("NAME_REQUIRED_FOR_ASSET_TYPE")] NameRequiredForAssetType = 32,
        /// <summary>
        /// Legacy qualifying questions cannot be in the same Lead Form as
        /// custom questions.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_LEGACY_QUALIFYING_QUESTIONS_DISALLOWED")] LeadFormLegacyQualifyingQuestionsDisallowed = 33,
        /// <summary>
        /// Unique name is required for this asset type.
        /// </summary>
        [pbr::OriginalName("NAME_CONFLICT_FOR_ASSET_TYPE")] NameConflictForAssetType = 34,
        /// <summary>
        /// Cannot modify asset source.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_ASSET_SOURCE")] CannotModifyAssetSource = 35,
        /// <summary>
        /// User can not modify the automatically created asset.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_AUTOMATICALLY_CREATED_ASSET")] CannotModifyAutomaticallyCreatedAsset = 36,
        /// <summary>
        /// Lead Form is disallowed to use "LOCATION" answer type.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_LOCATION_ANSWER_TYPE_DISALLOWED")] LeadFormLocationAnswerTypeDisallowed = 37,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
