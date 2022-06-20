using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Amazing.Software.Web;

[Dependency(ReplaceServices = true)]
public class SoftwareBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Software";
}
