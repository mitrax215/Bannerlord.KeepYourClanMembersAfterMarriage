using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;

namespace KeepYourClanMembersAfterMarriage.Patches
{
    [HarmonyPatch(typeof(DefaultMarriageModel))]
    class DefaultMarriageModelPatch
    {
        private static readonly bool KeepClanMembersAfterMarriage = Configs.Instance.KeepClanMembersAfterMarriage;

        [HarmonyPrefix]
        [HarmonyPatch("GetClanAfterMarriage")]
        public static bool GetClanAfterMarriage(Hero firstHero, Hero secondHero, ref Clan __result)
        {
            if (!KeepClanMembersAfterMarriage)
            {
                return true;
            }

            if (firstHero.Clan == Hero.MainHero.Clan)
            {
                __result = firstHero.Clan;

                return false;
            }
            else if (secondHero.Clan == Hero.MainHero.Clan)
            {
                __result = secondHero.Clan;

                return false;
            }

            return true;
        }
    }
}
