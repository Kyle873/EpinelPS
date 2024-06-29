﻿using nksrv.Utils;

namespace nksrv.LobbyServer.Msgs.Messenger
{
    [PacketPath("/messenger/proceed")]
    public class ProceedMsg : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = ReadData<ReqProceedMessage>();

            // TODO: save these things
            var response = new ResProceedMessage();

            WriteData(response);
        }
    }
}