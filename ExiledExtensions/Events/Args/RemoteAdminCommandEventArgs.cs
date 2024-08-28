using System;
using CommandSystem;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace ExiledExtensions.Events.Args
{
    public class RemoteAdminCommandEventArgs : EventArgs
    {
        public RemoteAdminCommandEventArgs(ServerEventType baseType, ICommandSender sender, string command, string[] arguments)
        {
            BaseType = baseType;
            Sender = sender;
            Command = command;
            Arguments = arguments;
        }

        public ServerEventType BaseType { get; } = ServerEventType.RemoteAdminCommand;
        public ICommandSender Sender { get; }
        public string Command { get; }
        public string[] Arguments { get; }
    }
}