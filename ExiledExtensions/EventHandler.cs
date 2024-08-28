using ExiledExtensions.Events.Args;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace ExiledExtensions
{
    public class EventHandler
    {
        [PluginEvent]
        public void OnRemoteAdminCommandExecuted(RemoteAdminCommandExecutedEvent ev)
        { 
            Events.Handlers.CommandHandler.RemoteAdmin.OnRemoteAdminCommandExecutedEvent(
                new RemoteAdminCommandExecutedEventArgs(ev.BaseType, ev.Sender, ev.Command, ev.Arguments, ev.Result, ev.Response));
        }

        [PluginEvent]
        public void OnRemoteAdminCommand(RemoteAdminCommandEvent ev)
        {
            Events.Handlers.CommandHandler.RemoteAdmin.OnRemoteAdminCommandEvent(
                new RemoteAdminCommandEventArgs(ev.BaseType, ev.Sender, ev.Command, ev.Arguments));
        }
        [PluginEvent]
        public void OnConsoleCommand(ConsoleCommandEvent ev)
        {
            Events.Handlers.CommandHandler.Console.OnConsoleCommand(
                new ConsoleCommandEventArgs(ev.BaseType, ev.Sender, ev.Command, ev.Arguments));
        }
        [PluginEvent]
        public void OnConsoleCommandExecuted(ConsoleCommandExecutedEvent ev)
        {
            Events.Handlers.CommandHandler.Console.OnConsoleCommandExecuted(
                new ConsoleCommandExecutedEventArgs(ev.BaseType, ev.Sender, ev.Command, ev.Arguments, ev.Result, ev.Response));
        }

        [PluginEvent]
        public void OnPlayerConsoleCommand(PlayerGameConsoleCommandEvent ev)
        {
            Events.Handlers.CommandHandler.Console.OnPlayerGameConsoleCommand(
                new PlayerGameConsoleCommandEventArgs(ev.BaseType, ev.Player, ev.Command, ev.Arguments));
        }

        [PluginEvent]
        public void OnPlayerConsoleCommandExecuted(PlayerGameConsoleCommandExecutedEvent ev)
        {
            Events.Handlers.CommandHandler.Console.OnPlayerGameConsoleCommandExecuted(
                new PlayerGameConsoleCommandExecutedEventArgs(ev.BaseType, ev.Player, ev.Command, ev.Arguments,
                    ev.Result, ev.Response));
        }
    }
}