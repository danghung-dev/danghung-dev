using Smartlog.rntest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Smartlog.rntest
{
    [DependsOn(
        typeof(rntestEntityFrameworkCoreTestModule)
        )]
    public class rntestDomainTestModule : AbpModule
    {

    }
}