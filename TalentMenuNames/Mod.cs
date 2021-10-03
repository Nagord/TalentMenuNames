using PulsarModLoader;

namespace TalentMenuNames
{
    class Mod : PulsarMod
    {
        public override string Version => "0.0.3";

        public override string Author => "Dragon";

        public override string ShortDescription => "Modifies Talent Menu to display Player Names instead of Player Class";

        public override string Name => "TalentMenuNames";

        public override string HarmonyIdentifier()
        {
            return "Dragon.TalentMenuNames";
        }
    }
}
