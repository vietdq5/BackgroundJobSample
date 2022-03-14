using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BackGroundJobDemo1.Web;

[Dependency(ReplaceServices = true)]
public class BackGroundJobDemo1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BackGroundJobDemo1";
}
