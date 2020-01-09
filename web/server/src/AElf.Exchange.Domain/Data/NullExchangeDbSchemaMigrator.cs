using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AElf.Exchange.Data
{
    /* This is used if database provider does't define
     * IExchangeDbSchemaMigrator implementation.
     */
    public class NullExchangeDbSchemaMigrator : IExchangeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}