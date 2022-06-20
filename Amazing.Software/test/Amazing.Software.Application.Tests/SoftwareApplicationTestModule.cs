using Volo.Abp.Modularity;

namespace Amazing.Software;

[DependsOn(
    typeof(SoftwareApplicationModule),
    typeof(SoftwareDomainTestModule)
    )]
public class SoftwareApplicationTestModule : AbpModule
{

}
