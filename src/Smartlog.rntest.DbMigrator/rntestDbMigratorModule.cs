using Smartlog.rntest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Smartlog.rntest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(rntestEntityFrameworkCoreDbMigrationsModule),
        typeof(rntestApplicationContractsModule)
        )]
    public class rntestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
