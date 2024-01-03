using StGabrielArms.TriggerTrade.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StGabrielArms.TriggerTrade.Permissions;

public class TriggerTradePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TriggerTradePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TriggerTradePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TriggerTradeResource>(name);
    }
}
