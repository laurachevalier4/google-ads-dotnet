// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/resources/offline_user_data_job.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/resources/offline_user_data_job.proto</summary>
  public static partial class OfflineUserDataJobReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/resources/offline_user_data_job.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9yZXNvdXJjZXMvb2ZmbGluZV91",
            "c2VyX2RhdGFfam9iLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5y",
            "ZXNvdXJjZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y2L2NvbW1vbi9vZmZs",
            "aW5lX3VzZXJfZGF0YS5wcm90bxpIZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjYv",
            "ZW51bXMvb2ZmbGluZV91c2VyX2RhdGFfam9iX2ZhaWx1cmVfcmVhc29uLnBy",
            "b3RvGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9vZmZsaW5lX3Vz",
            "ZXJfZGF0YV9qb2Jfc3RhdHVzLnByb3RvGj5nb29nbGUvYWRzL2dvb2dsZWFk",
            "cy92Ni9lbnVtcy9vZmZsaW5lX3VzZXJfZGF0YV9qb2JfdHlwZS5wcm90bxof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLQ",
            "BgoST2ZmbGluZVVzZXJEYXRhSm9iEkoKDXJlc291cmNlX25hbWUYASABKAlC",
            "M+BBBfpBLQorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL09mZmxpbmVVc2Vy",
            "RGF0YUpvYhIUCgJpZBgJIAEoA0ID4EEDSAGIAQESHQoLZXh0ZXJuYWxfaWQY",
            "CiABKANCA+BBBUgCiAEBEmMKBHR5cGUYBCABKA4yUC5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52Ni5lbnVtcy5PZmZsaW5lVXNlckRhdGFKb2JUeXBlRW51bS5P",
            "ZmZsaW5lVXNlckRhdGFKb2JUeXBlQgPgQQUSaQoGc3RhdHVzGAUgASgOMlQu",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjYuZW51bXMuT2ZmbGluZVVzZXJEYXRh",
            "Sm9iU3RhdHVzRW51bS5PZmZsaW5lVXNlckRhdGFKb2JTdGF0dXNCA+BBAxJ/",
            "Cg5mYWlsdXJlX3JlYXNvbhgGIAEoDjJiLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY2LmVudW1zLk9mZmxpbmVVc2VyRGF0YUpvYkZhaWx1cmVSZWFzb25FbnVt",
            "Lk9mZmxpbmVVc2VyRGF0YUpvYkZhaWx1cmVSZWFzb25CA+BBAxJvCiFjdXN0",
            "b21lcl9tYXRjaF91c2VyX2xpc3RfbWV0YWRhdGEYByABKAsyPS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Ni5jb21tb24uQ3VzdG9tZXJNYXRjaFVzZXJMaXN0",
            "TWV0YWRhdGFCA+BBBUgAElcKFHN0b3JlX3NhbGVzX21ldGFkYXRhGAggASgL",
            "MjIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjYuY29tbW9uLlN0b3JlU2FsZXNN",
            "ZXRhZGF0YUID4EEFSAA6e+pBeAorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L09mZmxpbmVVc2VyRGF0YUpvYhJJY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "b2ZmbGluZVVzZXJEYXRhSm9icy97b2ZmbGluZV91c2VyX2RhdGFfdXBkYXRl",
            "X2lkfUIKCghtZXRhZGF0YUIFCgNfaWRCDgoMX2V4dGVybmFsX2lkQoQCCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjYucmVzb3VyY2VzQhdPZmZsaW5l",
            "VXNlckRhdGFKb2JQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjYvcmVzb3VyY2VzO3Jlc291",
            "cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY2LlJlc291cmNl",
            "c8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY2XFJlc291cmNlc+oCJUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlY2OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Common.OfflineUserDataReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Resources.OfflineUserDataJob), global::Google.Ads.GoogleAds.V6.Resources.OfflineUserDataJob.Parser, new[]{ "ResourceName", "Id", "ExternalId", "Type", "Status", "FailureReason", "CustomerMatchUserListMetadata", "StoreSalesMetadata" }, new[]{ "Metadata", "Id", "ExternalId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A job containing offline user data of store visitors, or user list members
  /// that will be processed asynchronously. The uploaded data isn't readable and
  /// the processing results of the job can only be read using
  /// OfflineUserDataJobService.GetOfflineUserDataJob.
  /// </summary>
  public sealed partial class OfflineUserDataJob : pb::IMessage<OfflineUserDataJob>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJob> _parser = new pb::MessageParser<OfflineUserDataJob>(() => new OfflineUserDataJob());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OfflineUserDataJob> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Resources.OfflineUserDataJobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob(OfflineUserDataJob other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      externalId_ = other.externalId_;
      type_ = other.type_;
      status_ = other.status_;
      failureReason_ = other.failureReason_;
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          CustomerMatchUserListMetadata = other.CustomerMatchUserListMetadata.Clone();
          break;
        case MetadataOneofCase.StoreSalesMetadata:
          StoreSalesMetadata = other.StoreSalesMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob Clone() {
      return new OfflineUserDataJob(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the offline user data job.
    /// Offline user data job resource names have the form:
    ///
    /// `customers/{customer_id}/offlineUserDataJobs/{offline_user_data_job_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private long id_;
    /// <summary>
    /// Output only. ID of this offline user data job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "external_id" field.</summary>
    public const int ExternalIdFieldNumber = 10;
    private long externalId_;
    /// <summary>
    /// Immutable. User specified job ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExternalId {
      get { if ((_hasBits0 & 2) != 0) { return externalId_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        externalId_ = value;
      }
    }
    /// <summary>Gets whether the "external_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasExternalId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "external_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExternalId() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType type_ = global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified;
    /// <summary>
    /// Immutable. Type of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus status_ = global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified;
    /// <summary>
    /// Output only. Status of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "failure_reason" field.</summary>
    public const int FailureReasonFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason failureReason_ = global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified;
    /// <summary>
    /// Output only. Reason for the processing failure, if status is FAILED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason FailureReason {
      get { return failureReason_; }
      set {
        failureReason_ = value;
      }
    }

    /// <summary>Field number for the "customer_match_user_list_metadata" field.</summary>
    public const int CustomerMatchUserListMetadataFieldNumber = 7;
    /// <summary>
    /// Immutable. Metadata for data updates to a CRM-based user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata CustomerMatchUserListMetadata {
      get { return metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata ? (global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata) metadata_ : null; }
      set {
        metadata_ = value;
        metadataCase_ = value == null ? MetadataOneofCase.None : MetadataOneofCase.CustomerMatchUserListMetadata;
      }
    }

    /// <summary>Field number for the "store_sales_metadata" field.</summary>
    public const int StoreSalesMetadataFieldNumber = 8;
    /// <summary>
    /// Immutable. Metadata for store sales data update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata StoreSalesMetadata {
      get { return metadataCase_ == MetadataOneofCase.StoreSalesMetadata ? (global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata) metadata_ : null; }
      set {
        metadata_ = value;
        metadataCase_ = value == null ? MetadataOneofCase.None : MetadataOneofCase.StoreSalesMetadata;
      }
    }

    private object metadata_;
    /// <summary>Enum of possible cases for the "metadata" oneof.</summary>
    public enum MetadataOneofCase {
      None = 0,
      CustomerMatchUserListMetadata = 7,
      StoreSalesMetadata = 8,
    }
    private MetadataOneofCase metadataCase_ = MetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataOneofCase MetadataCase {
      get { return metadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMetadata() {
      metadataCase_ = MetadataOneofCase.None;
      metadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJob);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OfflineUserDataJob other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (ExternalId != other.ExternalId) return false;
      if (Type != other.Type) return false;
      if (Status != other.Status) return false;
      if (FailureReason != other.FailureReason) return false;
      if (!object.Equals(CustomerMatchUserListMetadata, other.CustomerMatchUserListMetadata)) return false;
      if (!object.Equals(StoreSalesMetadata, other.StoreSalesMetadata)) return false;
      if (MetadataCase != other.MetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasExternalId) hash ^= ExternalId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified) hash ^= Type.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified) hash ^= Status.GetHashCode();
      if (FailureReason != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified) hash ^= FailureReason.GetHashCode();
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) hash ^= CustomerMatchUserListMetadata.GetHashCode();
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) hash ^= StoreSalesMetadata.GetHashCode();
      hash ^= (int) metadataCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Type != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (FailureReason != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) FailureReason);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        output.WriteRawTag(58);
        output.WriteMessage(CustomerMatchUserListMetadata);
      }
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
        output.WriteRawTag(66);
        output.WriteMessage(StoreSalesMetadata);
      }
      if (HasId) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (HasExternalId) {
        output.WriteRawTag(80);
        output.WriteInt64(ExternalId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Type != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (FailureReason != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) FailureReason);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        output.WriteRawTag(58);
        output.WriteMessage(CustomerMatchUserListMetadata);
      }
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
        output.WriteRawTag(66);
        output.WriteMessage(StoreSalesMetadata);
      }
      if (HasId) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (HasExternalId) {
        output.WriteRawTag(80);
        output.WriteInt64(ExternalId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasExternalId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExternalId);
      }
      if (Type != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (FailureReason != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FailureReason);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomerMatchUserListMetadata);
      }
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StoreSalesMetadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OfflineUserDataJob other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasExternalId) {
        ExternalId = other.ExternalId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.Unspecified) {
        Type = other.Type;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.FailureReason != global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified) {
        FailureReason = other.FailureReason;
      }
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          if (CustomerMatchUserListMetadata == null) {
            CustomerMatchUserListMetadata = new global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata();
          }
          CustomerMatchUserListMetadata.MergeFrom(other.CustomerMatchUserListMetadata);
          break;
        case MetadataOneofCase.StoreSalesMetadata:
          if (StoreSalesMetadata == null) {
            StoreSalesMetadata = new global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata();
          }
          StoreSalesMetadata.MergeFrom(other.StoreSalesMetadata);
          break;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus) input.ReadEnum();
            break;
          }
          case 48: {
            FailureReason = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata subBuilder = new global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata();
            if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
              subBuilder.MergeFrom(CustomerMatchUserListMetadata);
            }
            input.ReadMessage(subBuilder);
            CustomerMatchUserListMetadata = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata subBuilder = new global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata();
            if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
              subBuilder.MergeFrom(StoreSalesMetadata);
            }
            input.ReadMessage(subBuilder);
            StoreSalesMetadata = subBuilder;
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            ExternalId = input.ReadInt64();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus) input.ReadEnum();
            break;
          }
          case 48: {
            FailureReason = (global::Google.Ads.GoogleAds.V6.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata subBuilder = new global::Google.Ads.GoogleAds.V6.Common.CustomerMatchUserListMetadata();
            if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
              subBuilder.MergeFrom(CustomerMatchUserListMetadata);
            }
            input.ReadMessage(subBuilder);
            CustomerMatchUserListMetadata = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata subBuilder = new global::Google.Ads.GoogleAds.V6.Common.StoreSalesMetadata();
            if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
              subBuilder.MergeFrom(StoreSalesMetadata);
            }
            input.ReadMessage(subBuilder);
            StoreSalesMetadata = subBuilder;
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            ExternalId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
