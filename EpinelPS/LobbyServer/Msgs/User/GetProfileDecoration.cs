﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Msgs.User
{
    [PacketPath("/ProfileCard/DecorationLayout/Get")]
    public class GetProfileDecoration : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqProfileCardDecorationLayout>();

            var r = new ResProfileCardDecorationLayout();
            r.Layout = new ProfileCardDecorationLayout();
            r.Layout.BackgroundId = 101002;
			r.Layout.ShowCharacterSpine = true;
            await WriteDataAsync(r);
        }
    }
}
