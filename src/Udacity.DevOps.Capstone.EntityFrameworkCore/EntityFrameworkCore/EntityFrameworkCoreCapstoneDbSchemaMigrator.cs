using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Udacity.DevOps.Capstone.Data;
using Volo.Abp.DependencyInjection;

namespace Udacity.DevOps.Capstone.EntityFrameworkCore;

public class EntityFrameworkCoreCapstoneDbSchemaMigrator
    : ICapstoneDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCapstoneDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CapstoneDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CapstoneDbContext>()
            .Database
            .MigrateAsync();
    }
}
