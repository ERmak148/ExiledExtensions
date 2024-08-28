
using ExiledExtensions.Events.Args;
using PluginAPI.Core;

namespace ExiledExtensions.Events.Handlers.CommandHandler
{
    public delegate void RemoteAdminCommandExecuted(RemoteAdminCommandExecutedEventArgs ev);
    public delegate void RemoteAdminCommand(RemoteAdminCommandEventArgs ev);
    public class RemoteAdmin
    {
        public static RemoteAdminCommandExecuted RemoteAdminCommandExecuted;
        public static RemoteAdminCommand RemoteAdminCommand;

        internal static RemoteAdminCommandExecutedEventArgs OnRemoteAdminCommandExecutedEvent(RemoteAdminCommandExecutedEventArgs ev)
        {
            if (RemoteAdminCommandExecuted != null)
            {
                foreach (RemoteAdminCommandExecuted? handler in RemoteAdminCommandExecuted.GetInvocationList())
                {
                    if (handler != null)
                    {
                        handler(ev);
                    }
                }
            }
            

            return ev;
        }
        internal static RemoteAdminCommandEventArgs OnRemoteAdminCommandEvent(RemoteAdminCommandEventArgs ev)
        {
            if (RemoteAdminCommand != null)
            {
                foreach (RemoteAdminCommand? handler in RemoteAdminCommand.GetInvocationList())
                {
                    if (handler != null)
                    {
                        handler(ev);
                    }
                }

            }
            
            return ev;
        }
        
    }
}