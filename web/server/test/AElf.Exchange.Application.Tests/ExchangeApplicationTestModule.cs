using Volo.Abp.Modularity;

namespace AElf.Exchange
{
    [DependsOn(
        typeof(ExchangeApplicationModule),
        typeof(ExchangeDomainTestModule)
        )]
    public class ExchangeApplicationTestModule : AbpModule
    {

    }
}