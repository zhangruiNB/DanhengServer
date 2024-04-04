// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SkillUseProperty.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SkillUseProperty.proto</summary>
  public static partial class SkillUsePropertyReflection {

    #region Descriptor
    /// <summary>File descriptor for SkillUseProperty.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkillUsePropertyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTa2lsbFVzZVByb3BlcnR5LnByb3RvIs8BChBTa2lsbFVzZVByb3BlcnR5",
            "EhAKCHNraWxsX2lkGAEgASgNEhIKCnNraWxsX3R5cGUYAiABKAkSEwoLc2tp",
            "bGxfbGV2ZWwYAyABKA0SFwoPc2tpbGxfdXNlX2NvdW50GAQgASgNEhMKC0dK",
            "QUlISkxGR0pNGAUgASgNEhMKC0ROQU1FSkhBSktKGAYgASgNEhMKC0tDQkZE",
            "T0FERE5EGAcgASgNEhMKC0FLTUdNQ0JERUVJGAggASgNEhMKC1BNTUtBS0tH",
            "SUtOGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SkillUseProperty), global::EggLink.DanhengServer.Proto.SkillUseProperty.Parser, new[]{ "SkillId", "SkillType", "SkillLevel", "SkillUseCount", "GJAIHJLFGJM", "DNAMEJHAJKJ", "KCBFDOADDND", "AKMGMCBDEEI", "PMMKAKKGIKN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SkillUseProperty : pb::IMessage<SkillUseProperty>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkillUseProperty> _parser = new pb::MessageParser<SkillUseProperty>(() => new SkillUseProperty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkillUseProperty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SkillUsePropertyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillUseProperty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillUseProperty(SkillUseProperty other) : this() {
      skillId_ = other.skillId_;
      skillType_ = other.skillType_;
      skillLevel_ = other.skillLevel_;
      skillUseCount_ = other.skillUseCount_;
      gJAIHJLFGJM_ = other.gJAIHJLFGJM_;
      dNAMEJHAJKJ_ = other.dNAMEJHAJKJ_;
      kCBFDOADDND_ = other.kCBFDOADDND_;
      aKMGMCBDEEI_ = other.aKMGMCBDEEI_;
      pMMKAKKGIKN_ = other.pMMKAKKGIKN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillUseProperty Clone() {
      return new SkillUseProperty(this);
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 1;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "skill_type" field.</summary>
    public const int SkillTypeFieldNumber = 2;
    private string skillType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SkillType {
      get { return skillType_; }
      set {
        skillType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "skill_level" field.</summary>
    public const int SkillLevelFieldNumber = 3;
    private uint skillLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillLevel {
      get { return skillLevel_; }
      set {
        skillLevel_ = value;
      }
    }

    /// <summary>Field number for the "skill_use_count" field.</summary>
    public const int SkillUseCountFieldNumber = 4;
    private uint skillUseCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillUseCount {
      get { return skillUseCount_; }
      set {
        skillUseCount_ = value;
      }
    }

    /// <summary>Field number for the "GJAIHJLFGJM" field.</summary>
    public const int GJAIHJLFGJMFieldNumber = 5;
    private uint gJAIHJLFGJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GJAIHJLFGJM {
      get { return gJAIHJLFGJM_; }
      set {
        gJAIHJLFGJM_ = value;
      }
    }

    /// <summary>Field number for the "DNAMEJHAJKJ" field.</summary>
    public const int DNAMEJHAJKJFieldNumber = 6;
    private uint dNAMEJHAJKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DNAMEJHAJKJ {
      get { return dNAMEJHAJKJ_; }
      set {
        dNAMEJHAJKJ_ = value;
      }
    }

    /// <summary>Field number for the "KCBFDOADDND" field.</summary>
    public const int KCBFDOADDNDFieldNumber = 7;
    private uint kCBFDOADDND_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KCBFDOADDND {
      get { return kCBFDOADDND_; }
      set {
        kCBFDOADDND_ = value;
      }
    }

    /// <summary>Field number for the "AKMGMCBDEEI" field.</summary>
    public const int AKMGMCBDEEIFieldNumber = 8;
    private uint aKMGMCBDEEI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AKMGMCBDEEI {
      get { return aKMGMCBDEEI_; }
      set {
        aKMGMCBDEEI_ = value;
      }
    }

    /// <summary>Field number for the "PMMKAKKGIKN" field.</summary>
    public const int PMMKAKKGIKNFieldNumber = 9;
    private uint pMMKAKKGIKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PMMKAKKGIKN {
      get { return pMMKAKKGIKN_; }
      set {
        pMMKAKKGIKN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkillUseProperty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkillUseProperty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SkillId != other.SkillId) return false;
      if (SkillType != other.SkillType) return false;
      if (SkillLevel != other.SkillLevel) return false;
      if (SkillUseCount != other.SkillUseCount) return false;
      if (GJAIHJLFGJM != other.GJAIHJLFGJM) return false;
      if (DNAMEJHAJKJ != other.DNAMEJHAJKJ) return false;
      if (KCBFDOADDND != other.KCBFDOADDND) return false;
      if (AKMGMCBDEEI != other.AKMGMCBDEEI) return false;
      if (PMMKAKKGIKN != other.PMMKAKKGIKN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (SkillType.Length != 0) hash ^= SkillType.GetHashCode();
      if (SkillLevel != 0) hash ^= SkillLevel.GetHashCode();
      if (SkillUseCount != 0) hash ^= SkillUseCount.GetHashCode();
      if (GJAIHJLFGJM != 0) hash ^= GJAIHJLFGJM.GetHashCode();
      if (DNAMEJHAJKJ != 0) hash ^= DNAMEJHAJKJ.GetHashCode();
      if (KCBFDOADDND != 0) hash ^= KCBFDOADDND.GetHashCode();
      if (AKMGMCBDEEI != 0) hash ^= AKMGMCBDEEI.GetHashCode();
      if (PMMKAKKGIKN != 0) hash ^= PMMKAKKGIKN.GetHashCode();
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
      if (SkillId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillId);
      }
      if (SkillType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SkillType);
      }
      if (SkillLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SkillLevel);
      }
      if (SkillUseCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillUseCount);
      }
      if (GJAIHJLFGJM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GJAIHJLFGJM);
      }
      if (DNAMEJHAJKJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DNAMEJHAJKJ);
      }
      if (KCBFDOADDND != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KCBFDOADDND);
      }
      if (AKMGMCBDEEI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AKMGMCBDEEI);
      }
      if (PMMKAKKGIKN != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PMMKAKKGIKN);
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
      if (SkillId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillId);
      }
      if (SkillType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SkillType);
      }
      if (SkillLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SkillLevel);
      }
      if (SkillUseCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillUseCount);
      }
      if (GJAIHJLFGJM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GJAIHJLFGJM);
      }
      if (DNAMEJHAJKJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DNAMEJHAJKJ);
      }
      if (KCBFDOADDND != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KCBFDOADDND);
      }
      if (AKMGMCBDEEI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AKMGMCBDEEI);
      }
      if (PMMKAKKGIKN != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PMMKAKKGIKN);
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
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (SkillType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SkillType);
      }
      if (SkillLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillLevel);
      }
      if (SkillUseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillUseCount);
      }
      if (GJAIHJLFGJM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GJAIHJLFGJM);
      }
      if (DNAMEJHAJKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DNAMEJHAJKJ);
      }
      if (KCBFDOADDND != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KCBFDOADDND);
      }
      if (AKMGMCBDEEI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AKMGMCBDEEI);
      }
      if (PMMKAKKGIKN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PMMKAKKGIKN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SkillUseProperty other) {
      if (other == null) {
        return;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.SkillType.Length != 0) {
        SkillType = other.SkillType;
      }
      if (other.SkillLevel != 0) {
        SkillLevel = other.SkillLevel;
      }
      if (other.SkillUseCount != 0) {
        SkillUseCount = other.SkillUseCount;
      }
      if (other.GJAIHJLFGJM != 0) {
        GJAIHJLFGJM = other.GJAIHJLFGJM;
      }
      if (other.DNAMEJHAJKJ != 0) {
        DNAMEJHAJKJ = other.DNAMEJHAJKJ;
      }
      if (other.KCBFDOADDND != 0) {
        KCBFDOADDND = other.KCBFDOADDND;
      }
      if (other.AKMGMCBDEEI != 0) {
        AKMGMCBDEEI = other.AKMGMCBDEEI;
      }
      if (other.PMMKAKKGIKN != 0) {
        PMMKAKKGIKN = other.PMMKAKKGIKN;
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 18: {
            SkillType = input.ReadString();
            break;
          }
          case 24: {
            SkillLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            SkillUseCount = input.ReadUInt32();
            break;
          }
          case 40: {
            GJAIHJLFGJM = input.ReadUInt32();
            break;
          }
          case 48: {
            DNAMEJHAJKJ = input.ReadUInt32();
            break;
          }
          case 56: {
            KCBFDOADDND = input.ReadUInt32();
            break;
          }
          case 64: {
            AKMGMCBDEEI = input.ReadUInt32();
            break;
          }
          case 72: {
            PMMKAKKGIKN = input.ReadUInt32();
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 18: {
            SkillType = input.ReadString();
            break;
          }
          case 24: {
            SkillLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            SkillUseCount = input.ReadUInt32();
            break;
          }
          case 40: {
            GJAIHJLFGJM = input.ReadUInt32();
            break;
          }
          case 48: {
            DNAMEJHAJKJ = input.ReadUInt32();
            break;
          }
          case 56: {
            KCBFDOADDND = input.ReadUInt32();
            break;
          }
          case 64: {
            AKMGMCBDEEI = input.ReadUInt32();
            break;
          }
          case 72: {
            PMMKAKKGIKN = input.ReadUInt32();
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