using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AElf.Exchange.Data;
using Volo.Abp.DependencyInjection;

namespace AElf.Exchange.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreExchangeDbSchemaMigrator 
        : IExchangeDbSchemaMigrator, ITransientDependency
    {
        private readonly ExchangeMigrationsDbContext _dbContext;

        public EntityFrameworkCoreExchangeDbSchemaMigrator(ExchangeMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}