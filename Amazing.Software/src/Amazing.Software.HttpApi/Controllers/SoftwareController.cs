using Amazing.Software.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Amazing.Software.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SoftwareController : AbpControllerBase
{
    protected SoftwareController()
    {
        LocalizationResource = typeof(SoftwareResource);
    }
}
