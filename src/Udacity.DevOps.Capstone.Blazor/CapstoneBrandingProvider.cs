using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Udacity.DevOps.Capstone.Blazor;

[Dependency(ReplaceServices = true)]
public class CapstoneBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Capstone";
}
