using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StGabrielArms.TriggerTrade.Data;

/* This is used if database provider does't define
 * ITriggerTradeDbSchemaMigrator implementation.
 */
public class NullTriggerTradeDbSchemaMigrator : ITriggerTradeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
