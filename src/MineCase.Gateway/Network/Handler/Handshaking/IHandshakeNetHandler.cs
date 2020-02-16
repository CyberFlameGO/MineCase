﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MineCase.Protocol.Handshaking;

namespace MineCase.Gateway.Network.Handler.Handshaking
{
    public interface IHandshakeNetHandler : INetHandler
    {
        Task ProcessHandshake(Handshake packet);
    }
}
