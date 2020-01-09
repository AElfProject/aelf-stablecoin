using AElf.Exchange.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AElf.Exchange.Permissions
{
    public class ExchangePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ExchangePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ExchangePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ExchangeResource>(name);
        }
    }
}
