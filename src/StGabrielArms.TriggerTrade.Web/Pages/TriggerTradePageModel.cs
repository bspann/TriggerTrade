using StGabrielArms.TriggerTrade.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StGabrielArms.TriggerTrade.Web.Pages;

public abstract class TriggerTradePageModel : AbpPageModel
{
    protected TriggerTradePageModel()
    {
        LocalizationResourceType = typeof(TriggerTradeResource);
    }
}
