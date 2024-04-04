// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StrongChallengeActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StrongChallengeActivityData.proto</summary>
  public static partial class StrongChallengeActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for StrongChallengeActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StrongChallengeActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eURhdGEucHJvdG8aH1N0cm9uZ0No",
            "YWxsZW5nZUF2YXRhckRhdGEucHJvdG8irQEKG1N0cm9uZ0NoYWxsZW5nZUFj",
            "dGl2aXR5RGF0YRITCgtFR0tFSUtOR0pPUBgGIAEoDRIQCghwYW5lbF9pZBgM",
            "IAEoDRITCgtMQ05OTUxPSEVIRRgHIAEoDRJAChxzdHJvbmdfY2hhbGxlbmdl",
            "X2F2YXRhcl9pbmZvGAMgASgLMhouU3Ryb25nQ2hhbGxlbmdlQXZhdGFyRGF0",
            "YRIQCghzdGFnZV9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.StrongChallengeAvatarDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StrongChallengeActivityData), global::EggLink.DanhengServer.Proto.StrongChallengeActivityData.Parser, new[]{ "EGKEIKNGJOP", "PanelId", "LCNNMLOHEHE", "StrongChallengeAvatarInfo", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StrongChallengeActivityData : pb::IMessage<StrongChallengeActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StrongChallengeActivityData> _parser = new pb::MessageParser<StrongChallengeActivityData>(() => new StrongChallengeActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StrongChallengeActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StrongChallengeActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData(StrongChallengeActivityData other) : this() {
      eGKEIKNGJOP_ = other.eGKEIKNGJOP_;
      panelId_ = other.panelId_;
      lCNNMLOHEHE_ = other.lCNNMLOHEHE_;
      strongChallengeAvatarInfo_ = other.strongChallengeAvatarInfo_ != null ? other.strongChallengeAvatarInfo_.Clone() : null;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityData Clone() {
      return new StrongChallengeActivityData(this);
    }

    /// <summary>Field number for the "EGKEIKNGJOP" field.</summary>
    public const int EGKEIKNGJOPFieldNumber = 6;
    private uint eGKEIKNGJOP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EGKEIKNGJOP {
      get { return eGKEIKNGJOP_; }
      set {
        eGKEIKNGJOP_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 12;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    /// <summary>Field number for the "LCNNMLOHEHE" field.</summary>
    public const int LCNNMLOHEHEFieldNumber = 7;
    private uint lCNNMLOHEHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LCNNMLOHEHE {
      get { return lCNNMLOHEHE_; }
      set {
        lCNNMLOHEHE_ = value;
      }
    }

    /// <summary>Field number for the "strong_challenge_avatar_info" field.</summary>
    public const int StrongChallengeAvatarInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData strongChallengeAvatarInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData StrongChallengeAvatarInfo {
      get { return strongChallengeAvatarInfo_; }
      set {
        strongChallengeAvatarInfo_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 10;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StrongChallengeActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StrongChallengeActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EGKEIKNGJOP != other.EGKEIKNGJOP) return false;
      if (PanelId != other.PanelId) return false;
      if (LCNNMLOHEHE != other.LCNNMLOHEHE) return false;
      if (!object.Equals(StrongChallengeAvatarInfo, other.StrongChallengeAvatarInfo)) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EGKEIKNGJOP != 0) hash ^= EGKEIKNGJOP.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
      if (LCNNMLOHEHE != 0) hash ^= LCNNMLOHEHE.GetHashCode();
      if (strongChallengeAvatarInfo_ != null) hash ^= StrongChallengeAvatarInfo.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (strongChallengeAvatarInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StrongChallengeAvatarInfo);
      }
      if (EGKEIKNGJOP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EGKEIKNGJOP);
      }
      if (LCNNMLOHEHE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LCNNMLOHEHE);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (strongChallengeAvatarInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StrongChallengeAvatarInfo);
      }
      if (EGKEIKNGJOP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EGKEIKNGJOP);
      }
      if (LCNNMLOHEHE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LCNNMLOHEHE);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EGKEIKNGJOP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EGKEIKNGJOP);
      }
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (LCNNMLOHEHE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LCNNMLOHEHE);
      }
      if (strongChallengeAvatarInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StrongChallengeAvatarInfo);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StrongChallengeActivityData other) {
      if (other == null) {
        return;
      }
      if (other.EGKEIKNGJOP != 0) {
        EGKEIKNGJOP = other.EGKEIKNGJOP;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
      }
      if (other.LCNNMLOHEHE != 0) {
        LCNNMLOHEHE = other.LCNNMLOHEHE;
      }
      if (other.strongChallengeAvatarInfo_ != null) {
        if (strongChallengeAvatarInfo_ == null) {
          StrongChallengeAvatarInfo = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
        }
        StrongChallengeAvatarInfo.MergeFrom(other.StrongChallengeAvatarInfo);
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 26: {
            if (strongChallengeAvatarInfo_ == null) {
              StrongChallengeAvatarInfo = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(StrongChallengeAvatarInfo);
            break;
          }
          case 48: {
            EGKEIKNGJOP = input.ReadUInt32();
            break;
          }
          case 56: {
            LCNNMLOHEHE = input.ReadUInt32();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
            break;
          }
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
          case 26: {
            if (strongChallengeAvatarInfo_ == null) {
              StrongChallengeAvatarInfo = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(StrongChallengeAvatarInfo);
            break;
          }
          case 48: {
            EGKEIKNGJOP = input.ReadUInt32();
            break;
          }
          case 56: {
            LCNNMLOHEHE = input.ReadUInt32();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
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