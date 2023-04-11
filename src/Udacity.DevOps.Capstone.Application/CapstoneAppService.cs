using System;
using System.Collections.Generic;
using System.Text;
using Udacity.DevOps.Capstone.Localization;
using Volo.Abp.Application.Services;

namespace Udacity.DevOps.Capstone;

/* Inherit your application services from this class.
 */
public abstract class CapstoneAppService : ApplicationService
{
    protected CapstoneAppService()
    {
        LocalizationResource = typeof(CapstoneResource);
    }
}
