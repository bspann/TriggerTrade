using Volo.Abp.Modularity;

namespace StGabrielArms.TriggerTrade;

public abstract class TriggerTradeApplicationTestBase<TStartupModule> : TriggerTradeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
