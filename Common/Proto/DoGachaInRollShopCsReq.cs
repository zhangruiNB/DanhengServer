// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DoGachaInRollShopCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DoGachaInRollShopCsReq.proto</summary>
  public static partial class DoGachaInRollShopCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DoGachaInRollShopCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DoGachaInRollShopCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxEb0dhY2hhSW5Sb2xsU2hvcENzUmVxLnByb3RvIkMKFkRvR2FjaGFJblJv",
            "bGxTaG9wQ3NSZXESFAoMcm9sbF9zaG9wX2lkGAogASgNEhMKC0JCSklKSU5K",
            "QUZLGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DoGachaInRollShopCsReq), global::EggLink.DanhengServer.Proto.DoGachaInRollShopCsReq.Parser, new[]{ "RollShopId", "BBJIJINJAFK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DoGachaInRollShopCsReq : pb::IMessage<DoGachaInRollShopCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoGachaInRollShopCsReq> _parser = new pb::MessageParser<DoGachaInRollShopCsReq>(() => new DoGachaInRollShopCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoGachaInRollShopCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DoGachaInRollShopCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopCsReq(DoGachaInRollShopCsReq other) : this() {
      rollShopId_ = other.rollShopId_;
      bBJIJINJAFK_ = other.bBJIJINJAFK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopCsReq Clone() {
      return new DoGachaInRollShopCsReq(this);
    }

    /// <summary>Field number for the "roll_shop_id" field.</summary>
    public const int RollShopIdFieldNumber = 10;
    private uint rollShopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollShopId {
      get { return rollShopId_; }
      set {
        rollShopId_ = value;
      }
    }

    /// <summary>Field number for the "BBJIJINJAFK" field.</summary>
    public const int BBJIJINJAFKFieldNumber = 5;
    private uint bBJIJINJAFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BBJIJINJAFK {
      get { return bBJIJINJAFK_; }
      set {
        bBJIJINJAFK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoGachaInRollShopCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoGachaInRollShopCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RollShopId != other.RollShopId) return false;
      if (BBJIJINJAFK != other.BBJIJINJAFK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RollShopId != 0) hash ^= RollShopId.GetHashCode();
      if (BBJIJINJAFK != 0) hash ^= BBJIJINJAFK.GetHashCode();
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
      if (BBJIJINJAFK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BBJIJINJAFK);
      }
      if (RollShopId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RollShopId);
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
      if (BBJIJINJAFK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BBJIJINJAFK);
      }
      if (RollShopId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RollShopId);
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
      if (RollShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollShopId);
      }
      if (BBJIJINJAFK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BBJIJINJAFK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoGachaInRollShopCsReq other) {
      if (other == null) {
        return;
      }
      if (other.RollShopId != 0) {
        RollShopId = other.RollShopId;
      }
      if (other.BBJIJINJAFK != 0) {
        BBJIJINJAFK = other.BBJIJINJAFK;
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
          case 40: {
            BBJIJINJAFK = input.ReadUInt32();
            break;
          }
          case 80: {
            RollShopId = input.ReadUInt32();
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
          case 40: {
            BBJIJINJAFK = input.ReadUInt32();
            break;
          }
          case 80: {
            RollShopId = input.ReadUInt32();
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