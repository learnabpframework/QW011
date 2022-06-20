using Amazing.Software.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Amazing.Software.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SoftwarePageModel : AbpPageModel
{
    protected SoftwarePageModel()
    {
        LocalizationResourceType = typeof(SoftwareResource);
    }
}
