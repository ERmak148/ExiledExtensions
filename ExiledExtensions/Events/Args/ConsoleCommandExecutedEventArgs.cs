using System;
using CommandSystem;
using PluginAPI.Enums;

namespace ExiledExtensions.Events.Args
{
    public class ConsoleCommandExecutedEventArgs : EventArgs
    {
        public ConsoleCommandExecutedEventArgs(ServerEventType baseType, ICommandSender sender, string command,
            string[] arguments, bool result, string response)
        {
            BaseType = baseType;
            Sender = sender;
            Command = command;
            Arguments = arguments;
            Result = result;
            Response = response;
        }

        public ServerEventType BaseType { get; } = ServerEventType.ConsoleCommandExecuted;
        public ICommandSender Sender { get; }
        public string Command { get; }
        public string[] Arguments { get; }
        public bool Result { get; }
        public string Response { get; }
    }
}