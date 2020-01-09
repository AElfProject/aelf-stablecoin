using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AElf.Exchange.EntityFrameworkCore
{
    [DependsOn(
        typeof(ExchangeEntityFrameworkCoreModule)
        )]
    public class ExchangeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ExchangeMigrationsDbContext>();
        }
    }
}
