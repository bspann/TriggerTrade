using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StGabrielArms.TriggerTrade.Data;
using Volo.Abp.DependencyInjection;

namespace StGabrielArms.TriggerTrade.EntityFrameworkCore;

public class EntityFrameworkCoreTriggerTradeDbSchemaMigrator
    : ITriggerTradeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTriggerTradeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TriggerTradeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TriggerTradeDbContext>()
            .Database
            .MigrateAsync();
    }
}
