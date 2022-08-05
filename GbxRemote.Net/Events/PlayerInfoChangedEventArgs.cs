﻿using System;
using GbxRemoteNet.Structs;

namespace GbxRemoteNet.Events;

public class PlayerInfoChangedEventArgs : EventArgs
{
    /// <summary>
    /// New information about the player.
    /// </summary>
    public TmSPlayerInfo PlayerInfo { get; set; }
}