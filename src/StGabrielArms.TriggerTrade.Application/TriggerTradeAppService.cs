using System;
using System.Collections.Generic;
using System.Text;
using StGabrielArms.TriggerTrade.Localization;
using Volo.Abp.Application.Services;

namespace StGabrielArms.TriggerTrade;

/* Inherit your application services from this class.
 */
public abstract class TriggerTradeAppService : ApplicationService
{
    protected TriggerTradeAppService()
    {
        LocalizationResource = typeof(TriggerTradeResource);
    }
}
