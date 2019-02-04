// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/change_status_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/change_status_service.proto</summary>
  public static partial class ChangeStatusServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/change_status_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9jaGFuZ2Vfc3Rh",
            "dHVzX3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNl",
            "cnZpY2VzGjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY2hh",
            "bmdlX3N0YXR1cy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byIvChZHZXRDaGFuZ2VTdGF0dXNSZXF1ZXN0EhUKDXJlc291cmNlX25hbWUY",
            "ASABKAkyzAEKE0NoYW5nZVN0YXR1c1NlcnZpY2UStAEKD0dldENoYW5nZVN0",
            "YXR1cxI4Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2VzLkdldENo",
            "YW5nZVN0YXR1c1JlcXVlc3QaLy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5y",
            "ZXNvdXJjZXMuQ2hhbmdlU3RhdHVzIjaC0+STAjASLi92MC97cmVzb3VyY2Vf",
            "bmFtZT1jdXN0b21lcnMvKi9jaGFuZ2VTdGF0dXMvKn1C/wEKJGNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlc0IYQ2hhbmdlU3RhdHVzU2Vy",
            "dmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dB",
            "QaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLlNlcnZpY2VzygIgR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjBcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMDo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.ChangeStatusReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetChangeStatusRequest), global::Google.Ads.GoogleAds.V0.Services.GetChangeStatusRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for '[ChangeStatusService.GetChangeStatus][google.ads.googleads.v0.services.ChangeStatusService.GetChangeStatus]'.
  /// </summary>
  public sealed partial class GetChangeStatusRequest : pb::IMessage<GetChangeStatusRequest> {
    private static readonly pb::MessageParser<GetChangeStatusRequest> _parser = new pb::MessageParser<GetChangeStatusRequest>(() => new GetChangeStatusRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetChangeStatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.ChangeStatusServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetChangeStatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetChangeStatusRequest(GetChangeStatusRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetChangeStatusRequest Clone() {
      return new GetChangeStatusRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the change status to fetch.
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
      return Equals(other as GetChangeStatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetChangeStatusRequest other) {
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

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
    public void MergeFrom(GetChangeStatusRequest other) {
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
    }

  }

  #endregion

}

#endregion Designer generated code
