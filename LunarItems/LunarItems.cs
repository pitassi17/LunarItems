using BepInEx;
using R2API.Utils;

namespace CustomLunarStuff
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [R2APISubmoduleDependency(new string[] { "ResourcesAPI", "LanguageAPI", "ItemAPI" })]
    [BepInPlugin(modGuid, modName, modVer)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    public sealed class CustomLunarItems : BaseUnityPlugin
    {
        private const string modName = "CustomLunarItems";
        private const string modGuid = "com.TheOneTrueGod." + modName;
        private const string modVer = "1.0.0";
        internal static CustomLunarItems instance;

        private void Awake()
        {
            if (instance == null) instance = this;
            StopMovingItem.Init();
            StayDownItem.Init();
        }
    }
}