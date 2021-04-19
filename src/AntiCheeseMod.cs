using HarmonyLib;
using Vintagestory.API.Client;
using Vintagestory.API.Common;

using Vintagestory.GameContent;
using Vintagestory.Client.NoObf;
using System.Reflection;
using System.Diagnostics;
using System;

[assembly: ModInfo("AntiCheese")]

namespace AntiCheese {
  public class AntiCheeseMod : ModSystem {
    public override void StartClientSide(ICoreClientAPI capi) {
      var harmony = new Harmony("goxmeor.AntiCheese");
      harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
  }
}
