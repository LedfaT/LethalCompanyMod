using BepInEx;

namespace lethalCompanyMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class SomeMod : BaseUnityPlugin
    {
        private const string modGUID = "Somemod.ByMe";
        private const string modName = "Somemod";
        private const string modVersion = "1.0.0";
    }
}