// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooBornScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooBornScRsp.proto</summary>
  public static partial class SpaceZooBornScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooBornScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooBornScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0Jvcm5TY1JzcC5wcm90bxoRQUdGT0NOQUpER0wucHJvdG8a",
            "EUhCQUlIQUpCT05PLnByb3RvIn8KEVNwYWNlWm9vQm9yblNjUnNwEg8KB3Jl",
            "dGNvZGUYDCABKA0SEwoLUExHR1BHR0xNSUkYBiABKAgSIQoLSEpMQU9DQUJD",
            "SkYYBSABKAsyDC5IQkFJSEFKQk9OTxIhCgtCR0xCS01JRENLUBgEIAMoCzIM",
            "LkFHRk9DTkFKREdMQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AGFOCNAJDGLReflection.Descriptor, global::EggLink.DanhengServer.Proto.HBAIHAJBONOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooBornScRsp), global::EggLink.DanhengServer.Proto.SpaceZooBornScRsp.Parser, new[]{ "Retcode", "PLGGPGGLMII", "HJLAOCABCJF", "BGLBKMIDCKP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooBornScRsp : pb::IMessage<SpaceZooBornScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooBornScRsp> _parser = new pb::MessageParser<SpaceZooBornScRsp>(() => new SpaceZooBornScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooBornScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooBornScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp(SpaceZooBornScRsp other) : this() {
      retcode_ = other.retcode_;
      pLGGPGGLMII_ = other.pLGGPGGLMII_;
      hJLAOCABCJF_ = other.hJLAOCABCJF_ != null ? other.hJLAOCABCJF_.Clone() : null;
      bGLBKMIDCKP_ = other.bGLBKMIDCKP_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp Clone() {
      return new SpaceZooBornScRsp(this);
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

    /// <summary>Field number for the "PLGGPGGLMII" field.</summary>
    public const int PLGGPGGLMIIFieldNumber = 6;
    private bool pLGGPGGLMII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PLGGPGGLMII {
      get { return pLGGPGGLMII_; }
      set {
        pLGGPGGLMII_ = value;
      }
    }

    /// <summary>Field number for the "HJLAOCABCJF" field.</summary>
    public const int HJLAOCABCJFFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.HBAIHAJBONO hJLAOCABCJF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HBAIHAJBONO HJLAOCABCJF {
      get { return hJLAOCABCJF_; }
      set {
        hJLAOCABCJF_ = value;
      }
    }

    /// <summary>Field number for the "BGLBKMIDCKP" field.</summary>
    public const int BGLBKMIDCKPFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> _repeated_bGLBKMIDCKP_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.AGFOCNAJDGL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> bGLBKMIDCKP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> BGLBKMIDCKP {
      get { return bGLBKMIDCKP_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooBornScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooBornScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (PLGGPGGLMII != other.PLGGPGGLMII) return false;
      if (!object.Equals(HJLAOCABCJF, other.HJLAOCABCJF)) return false;
      if(!bGLBKMIDCKP_.Equals(other.bGLBKMIDCKP_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (PLGGPGGLMII != false) hash ^= PLGGPGGLMII.GetHashCode();
      if (hJLAOCABCJF_ != null) hash ^= HJLAOCABCJF.GetHashCode();
      hash ^= bGLBKMIDCKP_.GetHashCode();
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
      bGLBKMIDCKP_.WriteTo(output, _repeated_bGLBKMIDCKP_codec);
      if (hJLAOCABCJF_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(HJLAOCABCJF);
      }
      if (PLGGPGGLMII != false) {
        output.WriteRawTag(48);
        output.WriteBool(PLGGPGGLMII);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
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
      bGLBKMIDCKP_.WriteTo(ref output, _repeated_bGLBKMIDCKP_codec);
      if (hJLAOCABCJF_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(HJLAOCABCJF);
      }
      if (PLGGPGGLMII != false) {
        output.WriteRawTag(48);
        output.WriteBool(PLGGPGGLMII);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (PLGGPGGLMII != false) {
        size += 1 + 1;
      }
      if (hJLAOCABCJF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HJLAOCABCJF);
      }
      size += bGLBKMIDCKP_.CalculateSize(_repeated_bGLBKMIDCKP_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooBornScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.PLGGPGGLMII != false) {
        PLGGPGGLMII = other.PLGGPGGLMII;
      }
      if (other.hJLAOCABCJF_ != null) {
        if (hJLAOCABCJF_ == null) {
          HJLAOCABCJF = new global::EggLink.DanhengServer.Proto.HBAIHAJBONO();
        }
        HJLAOCABCJF.MergeFrom(other.HJLAOCABCJF);
      }
      bGLBKMIDCKP_.Add(other.bGLBKMIDCKP_);
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
          case 34: {
            bGLBKMIDCKP_.AddEntriesFrom(input, _repeated_bGLBKMIDCKP_codec);
            break;
          }
          case 42: {
            if (hJLAOCABCJF_ == null) {
              HJLAOCABCJF = new global::EggLink.DanhengServer.Proto.HBAIHAJBONO();
            }
            input.ReadMessage(HJLAOCABCJF);
            break;
          }
          case 48: {
            PLGGPGGLMII = input.ReadBool();
            break;
          }
          case 96: {
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
          case 34: {
            bGLBKMIDCKP_.AddEntriesFrom(ref input, _repeated_bGLBKMIDCKP_codec);
            break;
          }
          case 42: {
            if (hJLAOCABCJF_ == null) {
              HJLAOCABCJF = new global::EggLink.DanhengServer.Proto.HBAIHAJBONO();
            }
            input.ReadMessage(HJLAOCABCJF);
            break;
          }
          case 48: {
            PLGGPGGLMII = input.ReadBool();
            break;
          }
          case 96: {
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