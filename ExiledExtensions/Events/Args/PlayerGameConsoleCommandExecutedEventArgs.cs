using System;
using CommandSystem;
using PluginAPI.Core;
using PluginAPI.Enums;

namespace ExiledExtensions.Events.Args;

public class PlayerGameConsoleCommandExecutedEventArgs : EventArgs
{
    public PlayerGameConsoleCommandExecutedEventArgs(ServerEventType baseType, Player player, string command,
        string[] arguments, bool result, string response)
    {
        BaseType = baseType;
        Player = player;
        Command = command;
        Arguments = arguments;
        Result = result;
        Response = response;
    }

    public ServerEventType BaseType { get; } = ServerEventType.PlayerGameConsoleCommandExecuted;
    public Player Player { get; }
    public string Command { get; }
    public string[] Arguments { get; }
    public bool Result { get; }
    public string Response { get; }
}