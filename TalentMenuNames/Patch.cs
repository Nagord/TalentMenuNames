using HarmonyLib;
using PulsarModLoader.Patches;
using System.Collections.Generic;
using System.Reflection.Emit;
using static PulsarModLoader.Patches.HarmonyHelpers;

namespace TalentMenuNames
{
    [HarmonyPatch(typeof(PLTabMenu), "UpdateTDs")]
    class TalentMenuNameFix
    {
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            List<CodeInstruction> targetSequence = new List<CodeInstruction>()
            {
                //new CodeInstruction(OpCodes.Ldloc_3),
                new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(PLPlayer), "GetClassName")),
                new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(System.String), "ToUpper")),
            };

            List<CodeInstruction> injectedSequence = new List<CodeInstruction>()
            {
                //new CodeInstruction(OpCodes.Ldloc_S, 3),
                new CodeInstruction(OpCodes.Ldc_I4_0),
                new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(PLPlayer), "GetPlayerName")),
            };

            return HarmonyHelpers.PatchBySequence(instructions, targetSequence, injectedSequence, PatchMode.REPLACE);
        }
    }
}
