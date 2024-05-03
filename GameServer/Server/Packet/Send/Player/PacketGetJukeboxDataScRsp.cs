﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Send.Player
{
    public class PacketGetJukeboxDataScRsp : BasePacket
    {
        public PacketGetJukeboxDataScRsp(PlayerInstance player) : base(CmdIds.GetJukeboxDataScRsp)
        {
            var proto = new GetJukeboxDataScRsp
            {
                CurrentMusicId = (uint)player.Data.CurrentBgm,
            };

            foreach (var music in GameData.BackGroundMusicData.Values)
            {
                proto.UnlockedMusicList.Add(new MusicData()
                {
                    Id = (uint)music.ID,
                    GroupId = (uint)music.GroupID,
                    IsPlayed = true
                });
            }

            SetData(proto);
        }
    }
}
