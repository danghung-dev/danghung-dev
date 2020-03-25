using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smartlog.rntest.Data;
using Volo.Abp.DependencyInjection;

namespace Smartlog.rntest.EntityFrameworkCore
{
    public class EntityFrameworkCorerntestDbSchemaMigrator
        : IrntestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorerntestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the rntestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<rntestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}