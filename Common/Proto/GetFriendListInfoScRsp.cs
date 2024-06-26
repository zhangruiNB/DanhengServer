// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFriendListInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFriendListInfoScRsp.proto</summary>
  public static partial class GetFriendListInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFriendListInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFriendListInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRGcmllbmRMaXN0SW5mb1NjUnNwLnByb3RvGhZQbGF5ZXJTaW1wbGVJ",
            "bmZvLnByb3RvGhZGcmllbmRTaW1wbGVJbmZvLnByb3RvIngKFkdldEZyaWVu",
            "ZExpc3RJbmZvU2NSc3ASJQoKYmxhY2tfbGlzdBgCIAMoCzIRLlBsYXllclNp",
            "bXBsZUluZm8SJgoLZnJpZW5kX2xpc3QYDSADKAsyES5GcmllbmRTaW1wbGVJ",
            "bmZvEg8KB3JldGNvZGUYCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerSimpleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.FriendSimpleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFriendListInfoScRsp), global::EggLink.DanhengServer.Proto.GetFriendListInfoScRsp.Parser, new[]{ "BlackList", "FriendList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFriendListInfoScRsp : pb::IMessage<GetFriendListInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFriendListInfoScRsp> _parser = new pb::MessageParser<GetFriendListInfoScRsp>(() => new GetFriendListInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFriendListInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFriendListInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendListInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendListInfoScRsp(GetFriendListInfoScRsp other) : this() {
      blackList_ = other.blackList_.Clone();
      friendList_ = other.friendList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendListInfoScRsp Clone() {
      return new GetFriendListInfoScRsp(this);
    }

    /// <summary>Field number for the "black_list" field.</summary>
    public const int BlackListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PlayerSimpleInfo> _repeated_blackList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.PlayerSimpleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerSimpleInfo> blackList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerSimpleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerSimpleInfo> BlackList {
      get { return blackList_; }
    }

    /// <summary>Field number for the "friend_list" field.</summary>
    public const int FriendListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FriendSimpleInfo> _repeated_friendList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.FriendSimpleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FriendSimpleInfo> friendList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FriendSimpleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FriendSimpleInfo> FriendList {
      get { return friendList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFriendListInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFriendListInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!blackList_.Equals(other.blackList_)) return false;
      if(!friendList_.Equals(other.friendList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= blackList_.GetHashCode();
      hash ^= friendList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      blackList_.WriteTo(output, _repeated_blackList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      friendList_.WriteTo(output, _repeated_friendList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      blackList_.WriteTo(ref output, _repeated_blackList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      friendList_.WriteTo(ref output, _repeated_friendList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += blackList_.CalculateSize(_repeated_blackList_codec);
      size += friendList_.CalculateSize(_repeated_friendList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFriendListInfoScRsp other) {
      if (other == null) {
        return;
      }
      blackList_.Add(other.blackList_);
      friendList_.Add(other.friendList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 18: {
            blackList_.AddEntriesFrom(input, _repeated_blackList_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            friendList_.AddEntriesFrom(input, _repeated_friendList_codec);
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
          case 18: {
            blackList_.AddEntriesFrom(ref input, _repeated_blackList_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            friendList_.AddEntriesFrom(ref input, _repeated_friendList_codec);
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
