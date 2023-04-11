using Udacity.DevOps.Capstone.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Udacity.DevOps.Capstone.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CapstoneController : AbpControllerBase
{
    protected CapstoneController()
    {
        LocalizationResource = typeof(CapstoneResource);
    }
}
