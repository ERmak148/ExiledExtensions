using ExiledExtensions.Events.Args;

namespace ExiledExtensions.Events.Handlers.CommandHandler
{
    public delegate void ConsoleCommand(ConsoleCommandEventArgs ev);
    public delegate void PlayerGameConsoleCommand(PlayerGameConsoleCommandEventArgs ev);
    public delegate void ConsoleCommandExecuted(ConsoleCommandExecutedEventArgs ev);
    public delegate void PlayerGameConsoleCommandExecuted(PlayerGameConsoleCommandExecutedEventArgs ev);
    public class Console
    {
        public static ConsoleCommand ConsoleCommand;
        public static PlayerGameConsoleCommand PlayerGameConsoleCommand;
        public static ConsoleCommandExecuted ConsoleCommandExecuted;
        public static PlayerGameConsoleCommandExecuted PlayerGameConsoleCommandExecuted;

        internal static ConsoleCommandEventArgs OnConsoleCommand(ConsoleCommandEventArgs ev)
        {
            if (ConsoleCommand != null)
            {
                foreach (ConsoleCommand? handler in ConsoleCommand.GetInvocationList())
                {
                    if (handler != null)
                    {
                        handler(ev);
                    }
                }
            }
            return ev;
        }
        internal static PlayerGameConsoleCommandEventArgs OnPlayerGameConsoleCommand(PlayerGameConsoleCommandEventArgs ev)
        {
            if (PlayerGameConsoleCommand != null)
            {
                foreach (PlayerGameConsoleCommand? handler in PlayerGameConsoleCommand.GetInvocationList())
                {
                    if (handler != null)
                    {
                        handler(ev);
                    }
                }
            }
            return ev;
        }
        internal static ConsoleCommandExecutedEventArgs OnConsoleCommandExecuted(ConsoleCommandExecutedEventArgs ev)
        {
            if (ConsoleCommandExecuted != null)
            {
                foreach (ConsoleCommandExecuted? handler in ConsoleCommandExecuted.GetInvocationList())
                {
                    if (handler != null)
                    {
                        handler(ev);
                    }
                
                }

            }
            
            return ev;
        }
        internal static PlayerGameConsoleCommandExecutedEventArgs OnPlayerGameConsoleCommandExecuted(PlayerGameConsoleCommandExecutedEventArgs ev)
        {
            if (PlayerGameConsoleCommandExecuted != null)
            {
                foreach (PlayerGameConsoleCommandExecuted? handler in PlayerGameConsoleCommandExecuted.GetInvocationList())
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