using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace KeepYourClanMembersAfterMarriage
{
    public class Configs : AttributeGlobalSettings<Configs>
    {
        public override string Id => "KeepYourClanMembersAfterMarriage";

        public override string DisplayName => "Keep Your Clan Members After Marriage";

        public override string FolderName => "KeepYourClanMembersAfterMarriage";

        public override string FormatType => "json2";

        private const string HeadingKeepClanMembersAfterMarriage = "Keep Your Clan Members After Marriage";

        [SettingPropertyBool(displayName: "Keep clan members", Order = 1, RequireRestart = false, HintText = "Allow a clan member to remain in your clan after they get married.")]
        [SettingPropertyGroup(HeadingKeepClanMembersAfterMarriage)]
        public bool KeepClanMembersAfterMarriage { get; set; } = true;
    }
}