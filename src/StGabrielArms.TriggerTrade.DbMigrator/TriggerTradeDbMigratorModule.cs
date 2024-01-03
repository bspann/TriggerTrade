using StGabrielArms.TriggerTrade.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace StGabrielArms.TriggerTrade.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(TriggerTradeEntityFrameworkCoreModule),
    typeof(TriggerTradeApplicationContractsModule)
    )]
public class TriggerTradeDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "TriggerTrade:"; });
    }
}
