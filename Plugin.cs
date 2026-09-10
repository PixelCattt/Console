using BepInEx;

namespace Console
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // Put this Code in your BaseUnityPlugin to load Console
        void Start() => ConsoleScripts.Console.LoadConsole();
    }
}