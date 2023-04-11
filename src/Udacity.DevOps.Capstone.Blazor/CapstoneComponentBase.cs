using Udacity.DevOps.Capstone.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Udacity.DevOps.Capstone.Blazor;

public abstract class CapstoneComponentBase : AbpComponentBase
{
    protected CapstoneComponentBase()
    {
        LocalizationResource = typeof(CapstoneResource);
    }
}
