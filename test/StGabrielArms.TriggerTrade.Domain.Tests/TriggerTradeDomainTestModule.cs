using Volo.Abp.Modularity;

namespace StGabrielArms.TriggerTrade;

[DependsOn(
    typeof(TriggerTradeDomainModule),
    typeof(TriggerTradeTestBaseModule)
)]
public class TriggerTradeDomainTestModule : AbpModule
{

}
