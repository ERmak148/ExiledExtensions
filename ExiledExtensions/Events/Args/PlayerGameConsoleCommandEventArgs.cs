using System;
using CommandSystem;
using PluginAPI.Core;
using PluginAPI.Enums;

namespace ExiledExtensions.Events.Args;

public class PlayerGameConsoleCommandEventArgs : EventArgs
{
    public PlayerGameConsoleCommandEventArgs(ServerEventType baseType, Player player, string command, string[] arguments)
    {
        BaseType = baseType;
        Player = player;
        Command = command;
        Arguments = arguments;
    }

    public ServerEventType BaseType { get; } = ServerEventType.PlayerGameConsoleCommand;
    public Player Player { get; }
    public string Command { get; }
    public string[] Arguments { get; }
}