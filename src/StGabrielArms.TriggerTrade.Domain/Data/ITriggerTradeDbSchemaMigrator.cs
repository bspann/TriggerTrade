using System.Threading.Tasks;

namespace StGabrielArms.TriggerTrade.Data;

public interface ITriggerTradeDbSchemaMigrator
{
    Task MigrateAsync();
}
