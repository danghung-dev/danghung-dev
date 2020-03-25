using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Smartlog.rntest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(rntestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class rntestConsoleApiClientModule : AbpModule
    {
        
    }
}
