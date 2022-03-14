using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackGroundJobDemo1.Data;
using Volo.Abp.DependencyInjection;

namespace BackGroundJobDemo1.EntityFrameworkCore;

public class EntityFrameworkCoreBackGroundJobDemo1DbSchemaMigrator
    : IBackGroundJobDemo1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBackGroundJobDemo1DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BackGroundJobDemo1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BackGroundJobDemo1DbContext>()
            .Database
            .MigrateAsync();
    }
}
