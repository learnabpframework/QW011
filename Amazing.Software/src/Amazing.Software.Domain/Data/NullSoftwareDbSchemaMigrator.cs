using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Amazing.Software.Data;

/* This is used if database provider does't define
 * ISoftwareDbSchemaMigrator implementation.
 */
public class NullSoftwareDbSchemaMigrator : ISoftwareDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
