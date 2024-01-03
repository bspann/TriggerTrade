using Volo.Abp.Modularity;

namespace StGabrielArms.TriggerTrade;

/* Inherit from this class for your domain layer tests. */
public abstract class TriggerTradeDomainTestBase<TStartupModule> : TriggerTradeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
