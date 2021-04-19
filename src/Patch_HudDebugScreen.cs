using HarmonyLib;
using Vintagestory.Client.NoObf;

namespace AntiCheese {
  [HarmonyPatch(typeof(HudDebugScreen))]
  [HarmonyPatch("OnRenderGUI")]
  public class Patch_HudDebugScreen_OnRenderGUI {
    static public bool Prefix() {
      return false; // HARMONY SKIP
    }
  }
}
