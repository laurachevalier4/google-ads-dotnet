// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/services/income_range_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/services/income_range_view_service.proto</summary>
  public static partial class IncomeRangeViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/services/income_range_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IncomeRangeViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9zZXJ2aWNlcy9pbmNvbWVfcmFu",
            "Z2Vfdmlld19zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "Ni5zZXJ2aWNlcxo5Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjYvcmVzb3VyY2Vz",
            "L2luY29tZV9yYW5nZV92aWV3LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2Fw",
            "aS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5w",
            "cm90byJkChlHZXRJbmNvbWVSYW5nZVZpZXdSZXF1ZXN0EkcKDXJlc291cmNl",
            "X25hbWUYASABKAlCMOBBAvpBKgooZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L0luY29tZVJhbmdlVmlldzKJAgoWSW5jb21lUmFuZ2VWaWV3U2VydmljZRLR",
            "AQoSR2V0SW5jb21lUmFuZ2VWaWV3EjsuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djYuc2VydmljZXMuR2V0SW5jb21lUmFuZ2VWaWV3UmVxdWVzdBoyLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY2LnJlc291cmNlcy5JbmNvbWVSYW5nZVZpZXci",
            "SoLT5JMCNBIyL3Y2L3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8qL2luY29t",
            "ZVJhbmdlVmlld3MvKn3aQQ1yZXNvdXJjZV9uYW1lGhvKQRhnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb21CggIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "Ni5zZXJ2aWNlc0IbSW5jb21lUmFuZ2VWaWV3U2VydmljZVByb3RvUAFaSGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92Ni9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlY2LlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjZcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNjo6U2Vy",
            "dmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Resources.IncomeRangeViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Services.GetIncomeRangeViewRequest), global::Google.Ads.GoogleAds.V6.Services.GetIncomeRangeViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [IncomeRangeViewService.GetIncomeRangeView][google.ads.googleads.v6.services.IncomeRangeViewService.GetIncomeRangeView].
  /// </summary>
  public sealed partial class GetIncomeRangeViewRequest : pb::IMessage<GetIncomeRangeViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetIncomeRangeViewRequest> _parser = new pb::MessageParser<GetIncomeRangeViewRequest>(() => new GetIncomeRangeViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetIncomeRangeViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Services.IncomeRangeViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncomeRangeViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncomeRangeViewRequest(GetIncomeRangeViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncomeRangeViewRequest Clone() {
      return new GetIncomeRangeViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the income range view to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetIncomeRangeViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetIncomeRangeViewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetIncomeRangeViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
