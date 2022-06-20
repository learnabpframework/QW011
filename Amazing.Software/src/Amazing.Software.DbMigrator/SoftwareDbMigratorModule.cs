using Amazing.Software.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Amazing.Software.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SoftwareEntityFrameworkCoreModule),
    typeof(SoftwareApplicationContractsModule)
    )]
public class SoftwareDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
