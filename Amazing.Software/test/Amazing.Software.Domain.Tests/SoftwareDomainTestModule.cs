using Amazing.Software.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Amazing.Software;

[DependsOn(
    typeof(SoftwareEntityFrameworkCoreTestModule)
    )]
public class SoftwareDomainTestModule : AbpModule
{

}
