using HarmonyLib;
using Vintagestory.API.Client;
using Vintagestory.API.Common;

[assembly: ModInfo("AntiCheese")]

namespace AntiCheese {
  public class AntiCheeseMod : ModSystem {
    public override void StartClientSide(ICoreClientAPI capi) {
      var harmony = new Harmony("goxmeor.DodgeThis");
      harmony.PatchAll();
    }
  }
}
