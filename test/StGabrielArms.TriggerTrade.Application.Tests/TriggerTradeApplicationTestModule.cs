using Volo.Abp.Modularity;

namespace StGabrielArms.TriggerTrade;

[DependsOn(
    typeof(TriggerTradeApplicationModule),
    typeof(TriggerTradeDomainTestModule)
)]
public class TriggerTradeApplicationTestModule : AbpModule
{

}
