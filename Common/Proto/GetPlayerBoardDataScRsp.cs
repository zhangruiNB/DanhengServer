// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetPlayerBoardDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetPlayerBoardDataScRsp.proto</summary>
  public static partial class GetPlayerBoardDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPlayerBoardDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPlayerBoardDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRQbGF5ZXJCb2FyZERhdGFTY1JzcC5wcm90bxoSSGVhZEljb25EYXRh",
            "LnByb3RvGhZEaXNwbGF5QXZhdGFyVmVjLnByb3RvItkBChdHZXRQbGF5ZXJC",
            "b2FyZERhdGFTY1JzcBIPCgdyZXRjb2RlGAwgASgNEhEKCXNpZ25hdHVyZRgJ",
            "IAEoCRIcChRjdXJyZW50X2hlYWRfaWNvbl9pZBgKIAEoDRIdChVhc3Npc3Rf",
            "YXZhdGFyX2lkX2xpc3QYDyADKA0SLQoSZGlzcGxheV9hdmF0YXJfdmVjGAsg",
            "ASgLMhEuRGlzcGxheUF2YXRhclZlYxIuChd1bmxvY2tlZF9oZWFkX2ljb25f",
            "bGlzdBgDIAMoCzINLkhlYWRJY29uRGF0YUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeadIconDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayAvatarVecReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetPlayerBoardDataScRsp), global::EggLink.DanhengServer.Proto.GetPlayerBoardDataScRsp.Parser, new[]{ "Retcode", "Signature", "CurrentHeadIconId", "AssistAvatarIdList", "DisplayAvatarVec", "UnlockedHeadIconList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetPlayerBoardDataScRsp : pb::IMessage<GetPlayerBoardDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetPlayerBoardDataScRsp> _parser = new pb::MessageParser<GetPlayerBoardDataScRsp>(() => new GetPlayerBoardDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetPlayerBoardDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetPlayerBoardDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerBoardDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerBoardDataScRsp(GetPlayerBoardDataScRsp other) : this() {
      retcode_ = other.retcode_;
      signature_ = other.signature_;
      currentHeadIconId_ = other.currentHeadIconId_;
      assistAvatarIdList_ = other.assistAvatarIdList_.Clone();
      displayAvatarVec_ = other.displayAvatarVec_ != null ? other.displayAvatarVec_.Clone() : null;
      unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerBoardDataScRsp Clone() {
      return new GetPlayerBoardDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 9;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_head_icon_id" field.</summary>
    public const int CurrentHeadIconIdFieldNumber = 10;
    private uint currentHeadIconId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentHeadIconId {
      get { return currentHeadIconId_; }
      set {
        currentHeadIconId_ = value;
      }
    }

    /// <summary>Field number for the "assist_avatar_id_list" field.</summary>
    public const int AssistAvatarIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_assistAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> assistAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AssistAvatarIdList {
      get { return assistAvatarIdList_; }
    }

    /// <summary>Field number for the "display_avatar_vec" field.</summary>
    public const int DisplayAvatarVecFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.DisplayAvatarVec displayAvatarVec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayAvatarVec DisplayAvatarVec {
      get { return displayAvatarVec_; }
      set {
        displayAvatarVec_ = value;
      }
    }

    /// <summary>Field number for the "unlocked_head_icon_list" field.</summary>
    public const int UnlockedHeadIconListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeadIconData> _repeated_unlockedHeadIconList_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.HeadIconData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData> unlockedHeadIconList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData> UnlockedHeadIconList {
      get { return unlockedHeadIconList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetPlayerBoardDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetPlayerBoardDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Signature != other.Signature) return false;
      if (CurrentHeadIconId != other.CurrentHeadIconId) return false;
      if(!assistAvatarIdList_.Equals(other.assistAvatarIdList_)) return false;
      if (!object.Equals(DisplayAvatarVec, other.DisplayAvatarVec)) return false;
      if(!unlockedHeadIconList_.Equals(other.unlockedHeadIconList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (CurrentHeadIconId != 0) hash ^= CurrentHeadIconId.GetHashCode();
      hash ^= assistAvatarIdList_.GetHashCode();
      if (displayAvatarVec_ != null) hash ^= DisplayAvatarVec.GetHashCode();
      hash ^= unlockedHeadIconList_.GetHashCode();
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
      unlockedHeadIconList_.WriteTo(output, _repeated_unlockedHeadIconList_codec);
      if (Signature.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Signature);
      }
      if (CurrentHeadIconId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurrentHeadIconId);
      }
      if (displayAvatarVec_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DisplayAvatarVec);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      assistAvatarIdList_.WriteTo(output, _repeated_assistAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unlockedHeadIconList_.WriteTo(ref output, _repeated_unlockedHeadIconList_codec);
      if (Signature.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Signature);
      }
      if (CurrentHeadIconId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurrentHeadIconId);
      }
      if (displayAvatarVec_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DisplayAvatarVec);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      assistAvatarIdList_.WriteTo(ref output, _repeated_assistAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (CurrentHeadIconId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentHeadIconId);
      }
      size += assistAvatarIdList_.CalculateSize(_repeated_assistAvatarIdList_codec);
      if (displayAvatarVec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DisplayAvatarVec);
      }
      size += unlockedHeadIconList_.CalculateSize(_repeated_unlockedHeadIconList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetPlayerBoardDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.CurrentHeadIconId != 0) {
        CurrentHeadIconId = other.CurrentHeadIconId;
      }
      assistAvatarIdList_.Add(other.assistAvatarIdList_);
      if (other.displayAvatarVec_ != null) {
        if (displayAvatarVec_ == null) {
          DisplayAvatarVec = new global::EggLink.DanhengServer.Proto.DisplayAvatarVec();
        }
        DisplayAvatarVec.MergeFrom(other.DisplayAvatarVec);
      }
      unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
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
            unlockedHeadIconList_.AddEntriesFrom(input, _repeated_unlockedHeadIconList_codec);
            break;
          }
          case 74: {
            Signature = input.ReadString();
            break;
          }
          case 80: {
            CurrentHeadIconId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (displayAvatarVec_ == null) {
              DisplayAvatarVec = new global::EggLink.DanhengServer.Proto.DisplayAvatarVec();
            }
            input.ReadMessage(DisplayAvatarVec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            assistAvatarIdList_.AddEntriesFrom(input, _repeated_assistAvatarIdList_codec);
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
            unlockedHeadIconList_.AddEntriesFrom(ref input, _repeated_unlockedHeadIconList_codec);
            break;
          }
          case 74: {
            Signature = input.ReadString();
            break;
          }
          case 80: {
            CurrentHeadIconId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (displayAvatarVec_ == null) {
              DisplayAvatarVec = new global::EggLink.DanhengServer.Proto.DisplayAvatarVec();
            }
            input.ReadMessage(DisplayAvatarVec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            assistAvatarIdList_.AddEntriesFrom(ref input, _repeated_assistAvatarIdList_codec);
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
