using BackGroundJobDemo1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BackGroundJobDemo1.Permissions;

public class BackGroundJobDemo1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BackGroundJobDemo1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BackGroundJobDemo1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BackGroundJobDemo1Resource>(name);
    }
}
