// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncChessRogueMainStoryFinishScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncChessRogueMainStoryFinishScNotify.proto</summary>
  public static partial class SyncChessRogueMainStoryFinishScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncChessRogueMainStoryFinishScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncChessRogueMainStoryFinishScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitTeW5jQ2hlc3NSb2d1ZU1haW5TdG9yeUZpbmlzaFNjTm90aWZ5LnByb3Rv",
            "IlMKJVN5bmNDaGVzc1JvZ3VlTWFpblN0b3J5RmluaXNoU2NOb3RpZnkSEwoL",
            "TUdGRURBQUZPSUIYCSABKA0SFQoNbWFpbl9zdG9yeV9pZBgCIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncChessRogueMainStoryFinishScNotify), global::EggLink.DanhengServer.Proto.SyncChessRogueMainStoryFinishScNotify.Parser, new[]{ "MGFEDAAFOIB", "MainStoryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncChessRogueMainStoryFinishScNotify : pb::IMessage<SyncChessRogueMainStoryFinishScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncChessRogueMainStoryFinishScNotify> _parser = new pb::MessageParser<SyncChessRogueMainStoryFinishScNotify>(() => new SyncChessRogueMainStoryFinishScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncChessRogueMainStoryFinishScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncChessRogueMainStoryFinishScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueMainStoryFinishScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueMainStoryFinishScNotify(SyncChessRogueMainStoryFinishScNotify other) : this() {
      mGFEDAAFOIB_ = other.mGFEDAAFOIB_;
      mainStoryId_ = other.mainStoryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueMainStoryFinishScNotify Clone() {
      return new SyncChessRogueMainStoryFinishScNotify(this);
    }

    /// <summary>Field number for the "MGFEDAAFOIB" field.</summary>
    public const int MGFEDAAFOIBFieldNumber = 9;
    private uint mGFEDAAFOIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGFEDAAFOIB {
      get { return mGFEDAAFOIB_; }
      set {
        mGFEDAAFOIB_ = value;
      }
    }

    /// <summary>Field number for the "main_story_id" field.</summary>
    public const int MainStoryIdFieldNumber = 2;
    private uint mainStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainStoryId {
      get { return mainStoryId_; }
      set {
        mainStoryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncChessRogueMainStoryFinishScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncChessRogueMainStoryFinishScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGFEDAAFOIB != other.MGFEDAAFOIB) return false;
      if (MainStoryId != other.MainStoryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGFEDAAFOIB != 0) hash ^= MGFEDAAFOIB.GetHashCode();
      if (MainStoryId != 0) hash ^= MainStoryId.GetHashCode();
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
      if (MainStoryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MainStoryId);
      }
      if (MGFEDAAFOIB != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MGFEDAAFOIB);
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
      if (MainStoryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MainStoryId);
      }
      if (MGFEDAAFOIB != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MGFEDAAFOIB);
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
      if (MGFEDAAFOIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGFEDAAFOIB);
      }
      if (MainStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainStoryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncChessRogueMainStoryFinishScNotify other) {
      if (other == null) {
        return;
      }
      if (other.MGFEDAAFOIB != 0) {
        MGFEDAAFOIB = other.MGFEDAAFOIB;
      }
      if (other.MainStoryId != 0) {
        MainStoryId = other.MainStoryId;
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
          case 16: {
            MainStoryId = input.ReadUInt32();
            break;
          }
          case 72: {
            MGFEDAAFOIB = input.ReadUInt32();
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
          case 16: {
            MainStoryId = input.ReadUInt32();
            break;
          }
          case 72: {
            MGFEDAAFOIB = input.ReadUInt32();
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
