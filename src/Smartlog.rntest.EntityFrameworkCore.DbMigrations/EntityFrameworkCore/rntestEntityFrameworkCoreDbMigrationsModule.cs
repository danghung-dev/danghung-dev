using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Smartlog.rntest.EntityFrameworkCore
{
    [DependsOn(
        typeof(rntestEntityFrameworkCoreModule)
        )]
    public class rntestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<rntestMigrationsDbContext>();
        }
    }
}
