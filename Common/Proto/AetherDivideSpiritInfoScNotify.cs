// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritInfoScNotify.proto</summary>
  public static partial class AetherDivideSpiritInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRBZXRoZXJEaXZpZGVTcGlyaXRJbmZvU2NOb3RpZnkucHJvdG8aHEFldGhl",
            "ckRpdmlkZVNwaXJpdEluZm8ucHJvdG8ikQEKHkFldGhlckRpdmlkZVNwaXJp",
            "dEluZm9TY05vdGlmeRITCgtETEZQT0RLR0JMSBgBIAEoDRIsCgtHUEZLSU5J",
            "REJEQRgDIAMoCzIXLkFldGhlckRpdmlkZVNwaXJpdEluZm8SLAoLc3Bpcml0",
            "X2luZm8YDSABKAsyFy5BZXRoZXJEaXZpZGVTcGlyaXRJbmZvQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotify), global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotify.Parser, new[]{ "DLFPODKGBLH", "GPFKINIDBDA", "SpiritInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritInfoScNotify : pb::IMessage<AetherDivideSpiritInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritInfoScNotify> _parser = new pb::MessageParser<AetherDivideSpiritInfoScNotify>(() => new AetherDivideSpiritInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify(AetherDivideSpiritInfoScNotify other) : this() {
      dLFPODKGBLH_ = other.dLFPODKGBLH_;
      gPFKINIDBDA_ = other.gPFKINIDBDA_.Clone();
      spiritInfo_ = other.spiritInfo_ != null ? other.spiritInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify Clone() {
      return new AetherDivideSpiritInfoScNotify(this);
    }

    /// <summary>Field number for the "DLFPODKGBLH" field.</summary>
    public const int DLFPODKGBLHFieldNumber = 1;
    private uint dLFPODKGBLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLFPODKGBLH {
      get { return dLFPODKGBLH_; }
      set {
        dLFPODKGBLH_ = value;
      }
    }

    /// <summary>Field number for the "GPFKINIDBDA" field.</summary>
    public const int GPFKINIDBDAFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> _repeated_gPFKINIDBDA_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> gPFKINIDBDA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> GPFKINIDBDA {
      get { return gPFKINIDBDA_; }
    }

    /// <summary>Field number for the "spirit_info" field.</summary>
    public const int SpiritInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo spiritInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo SpiritInfo {
      get { return spiritInfo_; }
      set {
        spiritInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DLFPODKGBLH != other.DLFPODKGBLH) return false;
      if(!gPFKINIDBDA_.Equals(other.gPFKINIDBDA_)) return false;
      if (!object.Equals(SpiritInfo, other.SpiritInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DLFPODKGBLH != 0) hash ^= DLFPODKGBLH.GetHashCode();
      hash ^= gPFKINIDBDA_.GetHashCode();
      if (spiritInfo_ != null) hash ^= SpiritInfo.GetHashCode();
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
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DLFPODKGBLH);
      }
      gPFKINIDBDA_.WriteTo(output, _repeated_gPFKINIDBDA_codec);
      if (spiritInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpiritInfo);
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
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DLFPODKGBLH);
      }
      gPFKINIDBDA_.WriteTo(ref output, _repeated_gPFKINIDBDA_codec);
      if (spiritInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpiritInfo);
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
      if (DLFPODKGBLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLFPODKGBLH);
      }
      size += gPFKINIDBDA_.CalculateSize(_repeated_gPFKINIDBDA_codec);
      if (spiritInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpiritInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.DLFPODKGBLH != 0) {
        DLFPODKGBLH = other.DLFPODKGBLH;
      }
      gPFKINIDBDA_.Add(other.gPFKINIDBDA_);
      if (other.spiritInfo_ != null) {
        if (spiritInfo_ == null) {
          SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
        }
        SpiritInfo.MergeFrom(other.SpiritInfo);
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
          case 8: {
            DLFPODKGBLH = input.ReadUInt32();
            break;
          }
          case 26: {
            gPFKINIDBDA_.AddEntriesFrom(input, _repeated_gPFKINIDBDA_codec);
            break;
          }
          case 106: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
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
          case 8: {
            DLFPODKGBLH = input.ReadUInt32();
            break;
          }
          case 26: {
            gPFKINIDBDA_.AddEntriesFrom(ref input, _repeated_gPFKINIDBDA_codec);
            break;
          }
          case 106: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
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
