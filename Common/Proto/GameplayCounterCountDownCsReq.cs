// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameplayCounterCountDownCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GameplayCounterCountDownCsReq.proto</summary>
  public static partial class GameplayCounterCountDownCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GameplayCounterCountDownCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameplayCounterCountDownCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNHYW1lcGxheUNvdW50ZXJDb3VudERvd25Dc1JlcS5wcm90byJJCh1HYW1l",
            "cGxheUNvdW50ZXJDb3VudERvd25Dc1JlcRITCgtHT0lKT0lCQkJDUBgOIAEo",
            "DRITCgtLT1BORkZJQ0JDSRgHIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GameplayCounterCountDownCsReq), global::EggLink.DanhengServer.Proto.GameplayCounterCountDownCsReq.Parser, new[]{ "GOIJOIBBBCP", "KOPNFFICBCI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GameplayCounterCountDownCsReq : pb::IMessage<GameplayCounterCountDownCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameplayCounterCountDownCsReq> _parser = new pb::MessageParser<GameplayCounterCountDownCsReq>(() => new GameplayCounterCountDownCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameplayCounterCountDownCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GameplayCounterCountDownCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayCounterCountDownCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayCounterCountDownCsReq(GameplayCounterCountDownCsReq other) : this() {
      gOIJOIBBBCP_ = other.gOIJOIBBBCP_;
      kOPNFFICBCI_ = other.kOPNFFICBCI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayCounterCountDownCsReq Clone() {
      return new GameplayCounterCountDownCsReq(this);
    }

    /// <summary>Field number for the "GOIJOIBBBCP" field.</summary>
    public const int GOIJOIBBBCPFieldNumber = 14;
    private uint gOIJOIBBBCP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GOIJOIBBBCP {
      get { return gOIJOIBBBCP_; }
      set {
        gOIJOIBBBCP_ = value;
      }
    }

    /// <summary>Field number for the "KOPNFFICBCI" field.</summary>
    public const int KOPNFFICBCIFieldNumber = 7;
    private uint kOPNFFICBCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KOPNFFICBCI {
      get { return kOPNFFICBCI_; }
      set {
        kOPNFFICBCI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameplayCounterCountDownCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameplayCounterCountDownCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GOIJOIBBBCP != other.GOIJOIBBBCP) return false;
      if (KOPNFFICBCI != other.KOPNFFICBCI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GOIJOIBBBCP != 0) hash ^= GOIJOIBBBCP.GetHashCode();
      if (KOPNFFICBCI != 0) hash ^= KOPNFFICBCI.GetHashCode();
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
      if (KOPNFFICBCI != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KOPNFFICBCI);
      }
      if (GOIJOIBBBCP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GOIJOIBBBCP);
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
      if (KOPNFFICBCI != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KOPNFFICBCI);
      }
      if (GOIJOIBBBCP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GOIJOIBBBCP);
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
      if (GOIJOIBBBCP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GOIJOIBBBCP);
      }
      if (KOPNFFICBCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KOPNFFICBCI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameplayCounterCountDownCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GOIJOIBBBCP != 0) {
        GOIJOIBBBCP = other.GOIJOIBBBCP;
      }
      if (other.KOPNFFICBCI != 0) {
        KOPNFFICBCI = other.KOPNFFICBCI;
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
          case 56: {
            KOPNFFICBCI = input.ReadUInt32();
            break;
          }
          case 112: {
            GOIJOIBBBCP = input.ReadUInt32();
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
          case 56: {
            KOPNFFICBCI = input.ReadUInt32();
            break;
          }
          case 112: {
            GOIJOIBBBCP = input.ReadUInt32();
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