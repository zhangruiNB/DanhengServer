// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAuthkeyCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAuthkeyCsReq.proto</summary>
  public static partial class GetAuthkeyCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAuthkeyCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAuthkeyCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHZXRBdXRoa2V5Q3NSZXEucHJvdG8iTQoPR2V0QXV0aGtleUNzUmVxEhMK",
            "C2F1dGhrZXlfdmVyGAYgASgJEhEKCXNpZ25fdHlwZRgMIAEoDRISCgphdXRo",
            "X2FwcGlkGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAuthkeyCsReq), global::EggLink.DanhengServer.Proto.GetAuthkeyCsReq.Parser, new[]{ "AuthkeyVer", "SignType", "AuthAppid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAuthkeyCsReq : pb::IMessage<GetAuthkeyCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAuthkeyCsReq> _parser = new pb::MessageParser<GetAuthkeyCsReq>(() => new GetAuthkeyCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAuthkeyCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAuthkeyCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq(GetAuthkeyCsReq other) : this() {
      authkeyVer_ = other.authkeyVer_;
      signType_ = other.signType_;
      authAppid_ = other.authAppid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq Clone() {
      return new GetAuthkeyCsReq(this);
    }

    /// <summary>Field number for the "authkey_ver" field.</summary>
    public const int AuthkeyVerFieldNumber = 6;
    private string authkeyVer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthkeyVer {
      get { return authkeyVer_; }
      set {
        authkeyVer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sign_type" field.</summary>
    public const int SignTypeFieldNumber = 12;
    private uint signType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignType {
      get { return signType_; }
      set {
        signType_ = value;
      }
    }

    /// <summary>Field number for the "auth_appid" field.</summary>
    public const int AuthAppidFieldNumber = 2;
    private uint authAppid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthAppid {
      get { return authAppid_; }
      set {
        authAppid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAuthkeyCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAuthkeyCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthkeyVer != other.AuthkeyVer) return false;
      if (SignType != other.SignType) return false;
      if (AuthAppid != other.AuthAppid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthkeyVer.Length != 0) hash ^= AuthkeyVer.GetHashCode();
      if (SignType != 0) hash ^= SignType.GetHashCode();
      if (AuthAppid != 0) hash ^= AuthAppid.GetHashCode();
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
      if (AuthAppid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AuthAppid);
      }
      if (AuthkeyVer.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AuthkeyVer);
      }
      if (SignType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SignType);
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
      if (AuthAppid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AuthAppid);
      }
      if (AuthkeyVer.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AuthkeyVer);
      }
      if (SignType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SignType);
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
      if (AuthkeyVer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthkeyVer);
      }
      if (SignType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignType);
      }
      if (AuthAppid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthAppid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAuthkeyCsReq other) {
      if (other == null) {
        return;
      }
      if (other.AuthkeyVer.Length != 0) {
        AuthkeyVer = other.AuthkeyVer;
      }
      if (other.SignType != 0) {
        SignType = other.SignType;
      }
      if (other.AuthAppid != 0) {
        AuthAppid = other.AuthAppid;
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
            AuthAppid = input.ReadUInt32();
            break;
          }
          case 50: {
            AuthkeyVer = input.ReadString();
            break;
          }
          case 96: {
            SignType = input.ReadUInt32();
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
            AuthAppid = input.ReadUInt32();
            break;
          }
          case 50: {
            AuthkeyVer = input.ReadString();
            break;
          }
          case 96: {
            SignType = input.ReadUInt32();
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