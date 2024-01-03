using StGabrielArms.TriggerTrade.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StGabrielArms.TriggerTrade.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TriggerTradeController : AbpControllerBase
{
    protected TriggerTradeController()
    {
        LocalizationResource = typeof(TriggerTradeResource);
    }
}
