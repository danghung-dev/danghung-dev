using Volo.Abp.Modularity;

namespace Smartlog.rntest
{
    [DependsOn(
        typeof(rntestApplicationModule),
        typeof(rntestDomainTestModule)
        )]
    public class rntestApplicationTestModule : AbpModule
    {

    }
}