using Harmony;
using System;
using System.Reflection;
using Verse;

namespace fumble.sidearm.yayo.patch
{
    public class Mod : Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            var harmony = HarmonyInstance.Create("Fumblesneeze.fumble.sidearm.yayo.patch");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
