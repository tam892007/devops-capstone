using Udacity.DevOps.Capstone.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Udacity.DevOps.Capstone.Permissions;

public class CapstonePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CapstonePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CapstonePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CapstoneResource>(name);
    }
}
