using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Amazing.Software.Data;
using Volo.Abp.DependencyInjection;

namespace Amazing.Software.EntityFrameworkCore;

public class EntityFrameworkCoreSoftwareDbSchemaMigrator
    : ISoftwareDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSoftwareDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SoftwareDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SoftwareDbContext>()
            .Database
            .MigrateAsync();
    }
}
