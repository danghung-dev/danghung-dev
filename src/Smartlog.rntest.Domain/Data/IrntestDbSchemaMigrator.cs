using System.Threading.Tasks;

namespace Smartlog.rntest.Data
{
    public interface IrntestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
