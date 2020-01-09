using AElf.Exchange.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AElf.Exchange.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ExchangeEntityFrameworkCoreDbMigrationsModule),
        typeof(ExchangeApplicationContractsModule)
        )]
    public class ExchangeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
