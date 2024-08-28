using System;
using CommandSystem;
using PluginAPI.Enums;

namespace ExiledExtensions.Events.Args
{
    public class ConsoleCommandEventArgs : EventArgs
    {
        public ConsoleCommandEventArgs(ServerEventType baseType, ICommandSender sender, string command, string[] arguments)
        {
            BaseType = baseType;
            Sender = sender;
            Command = command;
            Arguments = arguments;
        }

        public ServerEventType BaseType { get; } = ServerEventType.ConsoleCommand;
        public ICommandSender Sender { get; }
        public string Command { get; }
        public string[] Arguments { get; }
     
    }
}