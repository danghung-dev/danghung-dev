using Smartlog.rntest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Smartlog.rntest.Permissions
{
    public class rntestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(rntestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(rntestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<rntestResource>(name);
        }
    }
}
