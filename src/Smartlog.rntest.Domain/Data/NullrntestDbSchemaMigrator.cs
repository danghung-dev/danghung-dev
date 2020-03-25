using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Smartlog.rntest.Data
{
    /* This is used if database provider does't define
     * IrntestDbSchemaMigrator implementation.
     */
    public class NullrntestDbSchemaMigrator : IrntestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}