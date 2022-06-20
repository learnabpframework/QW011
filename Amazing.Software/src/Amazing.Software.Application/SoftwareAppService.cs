using System;
using System.Collections.Generic;
using System.Text;
using Amazing.Software.Localization;
using Volo.Abp.Application.Services;

namespace Amazing.Software;

/* Inherit your application services from this class.
 */
public abstract class SoftwareAppService : ApplicationService
{
    protected SoftwareAppService()
    {
        LocalizationResource = typeof(SoftwareResource);
    }
}
