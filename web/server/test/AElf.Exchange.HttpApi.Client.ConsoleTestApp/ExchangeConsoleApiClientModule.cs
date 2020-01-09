using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AElf.Exchange.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ExchangeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ExchangeConsoleApiClientModule : AbpModule
    {
        
    }
}
