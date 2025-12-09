using HarmonyLib;
using TaleWorlds.MountAndBlade;


namespace KeepYourClanMembersAfterMarriage
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            Harmony harmony = new Harmony("com.keepyourclanmembersaftermarriage");

            harmony.PatchAll();
        }
    }
}