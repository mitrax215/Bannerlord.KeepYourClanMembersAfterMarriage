using MCM.Abstractions.Base.Global;

namespace KeepYourClanMembersAfterMarriage
{
    public class Configs : AttributeGlobalSettings<Configs>
    {
        public override string Id => "KeepYourClanMembersAfterMarriage";

        public override string DisplayName => "Keep Your Clan Members After Marriage";

        public override string FolderName => "KeepYourClanMembersAfterMarriage";

        public override string FormatType => "json2";
    }
}