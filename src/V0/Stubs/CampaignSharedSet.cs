// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/campaign_shared_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/campaign_shared_set.proto</summary>
  public static partial class CampaignSharedSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/campaign_shared_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSharedSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "c2hhcmVkX3NldC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVz",
            "b3VyY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jYW1wYWln",
            "bl9zaGFyZWRfc2V0X3N0YXR1cy5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dy",
            "YXBwZXJzLnByb3RvIvABChFDYW1wYWlnblNoYXJlZFNldBIVCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJEi4KCGNhbXBhaWduGAMgASgLMhwuZ29vZ2xlLnByb3Rv",
            "YnVmLlN0cmluZ1ZhbHVlEjAKCnNoYXJlZF9zZXQYBCABKAsyHC5nb29nbGUu",
            "cHJvdG9idWYuU3RyaW5nVmFsdWUSYgoGc3RhdHVzGAIgASgOMlIuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAuZW51bXMuQ2FtcGFpZ25TaGFyZWRTZXRTdGF0",
            "dXNFbnVtLkNhbXBhaWduU2hhcmVkU2V0U3RhdHVzQoMCCiVjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzQhZDYW1wYWlnblNoYXJlZFNl",
            "dFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FB",
            "qgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuUmVzb3VyY2VzygIhR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjBcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjA6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.CampaignSharedSetStatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet), global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet.Parser, new[]{ "ResourceName", "Campaign", "SharedSet", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CampaignSharedSets are used for managing the shared sets associated with a
  /// campaign.
  /// </summary>
  public sealed partial class CampaignSharedSet : pb::IMessage<CampaignSharedSet> {
    private static readonly pb::MessageParser<CampaignSharedSet> _parser = new pb::MessageParser<CampaignSharedSet>(() => new CampaignSharedSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignSharedSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignSharedSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignSharedSet(CampaignSharedSet other) : this() {
      resourceName_ = other.resourceName_;
      Campaign = other.Campaign;
      SharedSet = other.SharedSet;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignSharedSet Clone() {
      return new CampaignSharedSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the campaign shared set.
    /// Campaign shared set resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSharedSets/{campaign_id}_{shared_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string campaign_;
    /// <summary>
    /// The campaign to which the campaign shared set belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }

    /// <summary>Field number for the "shared_set" field.</summary>
    public const int SharedSetFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_sharedSet_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string sharedSet_;
    /// <summary>
    /// The shared set associated with the campaign. This may be a negative keyword
    /// shared set of another customer. This customer should be a manager of the
    /// other customer, otherwise the campaign shared set will exist but have no
    /// serving effect. Only negative keyword shared sets can be associated with
    /// Shopping campaigns. Only negative placement shared sets can be associated
    /// with Display mobile app campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SharedSet {
      get { return sharedSet_; }
      set {
        sharedSet_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V0.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus status_ = 0;
    /// <summary>
    /// The status of this campaign shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignSharedSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignSharedSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (SharedSet != other.SharedSet) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      if (sharedSet_ != null) hash ^= SharedSet.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      if (sharedSet_ != null) {
        _single_sharedSet_codec.WriteTagAndValue(output, SharedSet);
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
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (sharedSet_ != null) {
        size += _single_sharedSet_codec.CalculateSizeWithTag(SharedSet);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignSharedSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      if (other.sharedSet_ != null) {
        if (sharedSet_ == null || other.SharedSet != "") {
          SharedSet = other.SharedSet;
        }
      }
      if (other.Status != 0) {
        Status = other.Status;
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
          case 16: {
            status_ = (global::Google.Ads.GoogleAds.V0.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus) input.ReadEnum();
            break;
          }
          case 26: {
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 34: {
            string value = _single_sharedSet_codec.Read(input);
            if (sharedSet_ == null || value != "") {
              SharedSet = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
