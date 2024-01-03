using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace StGabrielArms.TriggerTrade.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TriggerTradeDbContextFactory : IDesignTimeDbContextFactory<TriggerTradeDbContext>
{
    public TriggerTradeDbContext CreateDbContext(string[] args)
    {
        TriggerTradeEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TriggerTradeDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TriggerTradeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../StGabrielArms.TriggerTrade.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
