// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddAvatarSrcState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AddAvatarSrcState.proto</summary>
  public static partial class AddAvatarSrcStateReflection {

    #region Descriptor
    /// <summary>File descriptor for AddAvatarSrcState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddAvatarSrcStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdBZGRBdmF0YXJTcmNTdGF0ZS5wcm90bypgChFBZGRBdmF0YXJTcmNTdGF0",
            "ZRIXChNBRERfQVZBVEFSX1NSQ19OT05FEAASGAoUQUREX0FWQVRBUl9TUkNf",
            "R0FDSEEQARIYChRBRERfQVZBVEFSX1NSQ19ST0dVRRACQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.AddAvatarSrcState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AddAvatarSrcState {
    [pbr::OriginalName("ADD_AVATAR_SRC_NONE")] AddAvatarSrcNone = 0,
    [pbr::OriginalName("ADD_AVATAR_SRC_GACHA")] AddAvatarSrcGacha = 1,
    [pbr::OriginalName("ADD_AVATAR_SRC_ROGUE")] AddAvatarSrcRogue = 2,
  }

  #endregion

}

#endregion Designer generated code