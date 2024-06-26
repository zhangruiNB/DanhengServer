// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyGetRegionProgressScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyGetRegionProgressScRsp.proto</summary>
  public static partial class MonopolyGetRegionProgressScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyGetRegionProgressScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyGetRegionProgressScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRNb25vcG9seUdldFJlZ2lvblByb2dyZXNzU2NSc3AucHJvdG8ibQoeTW9u",
            "b3BvbHlHZXRSZWdpb25Qcm9ncmVzc1NjUnNwEhsKE3BlcnNvbmFsX2NvbnRy",
            "aWJ1dGUYBiABKA0SDwoHcmV0Y29kZRgHIAEoDRIdChVjb250cmlidXRpb25f",
            "cHJvZ3Jlc3MYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyGetRegionProgressScRsp), global::EggLink.DanhengServer.Proto.MonopolyGetRegionProgressScRsp.Parser, new[]{ "PersonalContribute", "Retcode", "ContributionProgress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyGetRegionProgressScRsp : pb::IMessage<MonopolyGetRegionProgressScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyGetRegionProgressScRsp> _parser = new pb::MessageParser<MonopolyGetRegionProgressScRsp>(() => new MonopolyGetRegionProgressScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyGetRegionProgressScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyGetRegionProgressScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGetRegionProgressScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGetRegionProgressScRsp(MonopolyGetRegionProgressScRsp other) : this() {
      personalContribute_ = other.personalContribute_;
      retcode_ = other.retcode_;
      contributionProgress_ = other.contributionProgress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGetRegionProgressScRsp Clone() {
      return new MonopolyGetRegionProgressScRsp(this);
    }

    /// <summary>Field number for the "personal_contribute" field.</summary>
    public const int PersonalContributeFieldNumber = 6;
    private uint personalContribute_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PersonalContribute {
      get { return personalContribute_; }
      set {
        personalContribute_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "contribution_progress" field.</summary>
    public const int ContributionProgressFieldNumber = 3;
    private uint contributionProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContributionProgress {
      get { return contributionProgress_; }
      set {
        contributionProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyGetRegionProgressScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyGetRegionProgressScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PersonalContribute != other.PersonalContribute) return false;
      if (Retcode != other.Retcode) return false;
      if (ContributionProgress != other.ContributionProgress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PersonalContribute != 0) hash ^= PersonalContribute.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ContributionProgress != 0) hash ^= ContributionProgress.GetHashCode();
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
      if (ContributionProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ContributionProgress);
      }
      if (PersonalContribute != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PersonalContribute);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      if (ContributionProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ContributionProgress);
      }
      if (PersonalContribute != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PersonalContribute);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      if (PersonalContribute != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PersonalContribute);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (ContributionProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContributionProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyGetRegionProgressScRsp other) {
      if (other == null) {
        return;
      }
      if (other.PersonalContribute != 0) {
        PersonalContribute = other.PersonalContribute;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ContributionProgress != 0) {
        ContributionProgress = other.ContributionProgress;
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
          case 24: {
            ContributionProgress = input.ReadUInt32();
            break;
          }
          case 48: {
            PersonalContribute = input.ReadUInt32();
            break;
          }
          case 56: {
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
          case 24: {
            ContributionProgress = input.ReadUInt32();
            break;
          }
          case 48: {
            PersonalContribute = input.ReadUInt32();
            break;
          }
          case 56: {
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
