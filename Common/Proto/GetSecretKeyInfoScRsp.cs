// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSecretKeyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSecretKeyInfoScRsp.proto</summary>
  public static partial class GetSecretKeyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSecretKeyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSecretKeyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRTZWNyZXRLZXlJbmZvU2NSc3AucHJvdG8aE1NlY3JldEtleUluZm8u",
            "cHJvdG8iYgoVR2V0U2VjcmV0S2V5SW5mb1NjUnNwEhMKC0RNTUdLQUdFSU9J",
            "GAEgASgMEg8KB3JldGNvZGUYCyABKA0SIwoLc2VjcmV0X2luZm8YAyADKAsy",
            "Di5TZWNyZXRLZXlJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SecretKeyInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRsp), global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRsp.Parser, new[]{ "DMMGKAGEIOI", "Retcode", "SecretInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSecretKeyInfoScRsp : pb::IMessage<GetSecretKeyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSecretKeyInfoScRsp> _parser = new pb::MessageParser<GetSecretKeyInfoScRsp>(() => new GetSecretKeyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSecretKeyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp(GetSecretKeyInfoScRsp other) : this() {
      dMMGKAGEIOI_ = other.dMMGKAGEIOI_;
      retcode_ = other.retcode_;
      secretInfo_ = other.secretInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp Clone() {
      return new GetSecretKeyInfoScRsp(this);
    }

    /// <summary>Field number for the "DMMGKAGEIOI" field.</summary>
    public const int DMMGKAGEIOIFieldNumber = 1;
    private pb::ByteString dMMGKAGEIOI_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString DMMGKAGEIOI {
      get { return dMMGKAGEIOI_; }
      set {
        dMMGKAGEIOI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "secret_info" field.</summary>
    public const int SecretInfoFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SecretKeyInfo> _repeated_secretInfo_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.SecretKeyInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SecretKeyInfo> secretInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SecretKeyInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SecretKeyInfo> SecretInfo {
      get { return secretInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSecretKeyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSecretKeyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DMMGKAGEIOI != other.DMMGKAGEIOI) return false;
      if (Retcode != other.Retcode) return false;
      if(!secretInfo_.Equals(other.secretInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DMMGKAGEIOI.Length != 0) hash ^= DMMGKAGEIOI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= secretInfo_.GetHashCode();
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
      if (DMMGKAGEIOI.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(DMMGKAGEIOI);
      }
      secretInfo_.WriteTo(output, _repeated_secretInfo_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (DMMGKAGEIOI.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(DMMGKAGEIOI);
      }
      secretInfo_.WriteTo(ref output, _repeated_secretInfo_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (DMMGKAGEIOI.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(DMMGKAGEIOI);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += secretInfo_.CalculateSize(_repeated_secretInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSecretKeyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.DMMGKAGEIOI.Length != 0) {
        DMMGKAGEIOI = other.DMMGKAGEIOI;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      secretInfo_.Add(other.secretInfo_);
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
          case 10: {
            DMMGKAGEIOI = input.ReadBytes();
            break;
          }
          case 26: {
            secretInfo_.AddEntriesFrom(input, _repeated_secretInfo_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
          case 10: {
            DMMGKAGEIOI = input.ReadBytes();
            break;
          }
          case 26: {
            secretInfo_.AddEntriesFrom(ref input, _repeated_secretInfo_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
