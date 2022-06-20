using System.Threading.Tasks;

namespace Amazing.Software.Data;

public interface ISoftwareDbSchemaMigrator
{
    Task MigrateAsync();
}
