using HarmonyLib;
using Vintagestory.GameContent;

namespace AntiCheese {
  [HarmonyPatch(typeof(EntityShapeRenderer))]
  [HarmonyPatch("OnDebugInfoChanged")]
  public class Patch_EntityShapeRenderer_OnDebugInfoChanged {
    static public bool Prefix() {
      return false; // HARMONY SKIP
    }
  }
}
