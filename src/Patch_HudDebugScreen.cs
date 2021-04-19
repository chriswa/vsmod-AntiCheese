using HarmonyLib;
using Vintagestory.Client.NoObf;

namespace AntiCheese {
  [HarmonyPatch(typeof(HudDebugScreen))]
  [HarmonyPatch("OnFinalizeFrame")]
  public class Patch_HudDebugScreen_OnFinalizeFrame {
    static bool Prefix() {
      return false; // HARMONY SKIP
    }
  }
}
