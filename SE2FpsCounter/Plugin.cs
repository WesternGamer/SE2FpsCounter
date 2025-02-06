using HarmonyLib;
using Keen.Game2.Client.UI.Library;
using Keen.Game2.Game.Plugins;
using Keen.VRage.Library.Diagnostics;
using System.Reflection;

namespace SE2FpsCounter
{
    public class Plugin : IPlugin
    {
        public const string Name = "SE2FpsCounter";

        internal static StatsOverlayScreenViewModel? ViewModel;

        internal static SharedUIComponent? SharedUI;

        public Plugin()
        {
            Log.Default.WriteLine($"[{Name}] Loaded plugin.");
#if DEBUG
            Harmony.DEBUG = true;
#endif
            Harmony harmony = new Harmony(Name);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Log.Default.WriteLine($"[{Name}] Applied patches");
        }
    }
}
