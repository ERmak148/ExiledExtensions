using ExiledExtensions.Events.Args;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace ExiledExtensions
{
    public class Plugin
    {
        [PluginEntryPoint("ExiledExtensions", "1.0.0.9", "UwU", "ermak158")]
        public void Start()
        {
            EventManager.RegisterEvents(this, new EventHandler());
        }
        
    }
}