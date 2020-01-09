using AElf.Exchange.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AElf.Exchange
{
    [DependsOn(
        typeof(ExchangeEntityFrameworkCoreTestModule)
        )]
    public class ExchangeDomainTestModule : AbpModule
    {

    }
}