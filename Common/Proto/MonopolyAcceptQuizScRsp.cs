// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyAcceptQuizScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyAcceptQuizScRsp.proto</summary>
  public static partial class MonopolyAcceptQuizScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyAcceptQuizScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyAcceptQuizScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Nb25vcG9seUFjY2VwdFF1aXpTY1JzcC5wcm90bxoRQk9EUEdDSklDSkEu",
            "cHJvdG8iTQoXTW9ub3BvbHlBY2NlcHRRdWl6U2NSc3ASIQoLSURPQkZFR0tM",
            "S1AYCSABKAsyDC5CT0RQR0NKSUNKQRIPCgdyZXRjb2RlGAQgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BODPGCJICJAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyAcceptQuizScRsp), global::EggLink.DanhengServer.Proto.MonopolyAcceptQuizScRsp.Parser, new[]{ "IDOBFEGKLKP", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyAcceptQuizScRsp : pb::IMessage<MonopolyAcceptQuizScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyAcceptQuizScRsp> _parser = new pb::MessageParser<MonopolyAcceptQuizScRsp>(() => new MonopolyAcceptQuizScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyAcceptQuizScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyAcceptQuizScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyAcceptQuizScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyAcceptQuizScRsp(MonopolyAcceptQuizScRsp other) : this() {
      iDOBFEGKLKP_ = other.iDOBFEGKLKP_ != null ? other.iDOBFEGKLKP_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyAcceptQuizScRsp Clone() {
      return new MonopolyAcceptQuizScRsp(this);
    }

    /// <summary>Field number for the "IDOBFEGKLKP" field.</summary>
    public const int IDOBFEGKLKPFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.BODPGCJICJA iDOBFEGKLKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BODPGCJICJA IDOBFEGKLKP {
      get { return iDOBFEGKLKP_; }
      set {
        iDOBFEGKLKP_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
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
      return Equals(other as MonopolyAcceptQuizScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyAcceptQuizScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IDOBFEGKLKP, other.IDOBFEGKLKP)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iDOBFEGKLKP_ != null) hash ^= IDOBFEGKLKP.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (iDOBFEGKLKP_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(IDOBFEGKLKP);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (iDOBFEGKLKP_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(IDOBFEGKLKP);
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
      if (iDOBFEGKLKP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IDOBFEGKLKP);
      }
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
    public void MergeFrom(MonopolyAcceptQuizScRsp other) {
      if (other == null) {
        return;
      }
      if (other.iDOBFEGKLKP_ != null) {
        if (iDOBFEGKLKP_ == null) {
          IDOBFEGKLKP = new global::EggLink.DanhengServer.Proto.BODPGCJICJA();
        }
        IDOBFEGKLKP.MergeFrom(other.IDOBFEGKLKP);
      }
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (iDOBFEGKLKP_ == null) {
              IDOBFEGKLKP = new global::EggLink.DanhengServer.Proto.BODPGCJICJA();
            }
            input.ReadMessage(IDOBFEGKLKP);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (iDOBFEGKLKP_ == null) {
              IDOBFEGKLKP = new global::EggLink.DanhengServer.Proto.BODPGCJICJA();
            }
            input.ReadMessage(IDOBFEGKLKP);
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