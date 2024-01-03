using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StGabrielArms.TriggerTrade.Web;

[Dependency(ReplaceServices = true)]
public class TriggerTradeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TriggerTrade";
}
