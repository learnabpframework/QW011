using Amazing.Software.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Amazing.Software.Permissions;

public class SoftwarePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SoftwarePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SoftwarePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SoftwareResource>(name);
    }
}
