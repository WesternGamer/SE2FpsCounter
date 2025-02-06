using HarmonyLib;
using Keen.Game2.Client.UI.Library;
using Keen.VRage.UI.EngineComponents;
using Keen.VRage.UI.Screens;

namespace SE2FpsCounter.Patches
{
    [HarmonyPatch(typeof(SharedUIComponent), "PostInit")]
    internal class SharedUIComponent_PostInit_Patch
    {
        private static void Postfix(UIEngineComponent ____ui)
        {
            Plugin.ViewModel = new StatsOverlayScreenViewModel();
            ____ui.ScreenManager.CreateAndAddScreen<StatsOverlayScreen>(Plugin.ViewModel, ScreenLayer.Debug, false);
        }
    }
}
