using PulsarPluginLoader;

namespace TalentMenuNames
{
    class Plugin : PulsarPlugin
    {
        public override string Version => "0.0.2";

        public override string Author => "Dragon";

        public override string ShortDescription => "Modifies Talent Menu to display Player Names instead of Player Class";

        public override string Name => "TalentMenuNames";

        public override string HarmonyIdentifier()
        {
            return "Dragon.TalentMenuNames";
        }
    }
}
