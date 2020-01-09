using System.Threading.Tasks;

namespace AElf.Exchange.Data
{
    public interface IExchangeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
