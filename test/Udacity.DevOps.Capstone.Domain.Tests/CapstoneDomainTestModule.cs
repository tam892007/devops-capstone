using Udacity.DevOps.Capstone.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Udacity.DevOps.Capstone;

[DependsOn(
    typeof(CapstoneEntityFrameworkCoreTestModule)
    )]
public class CapstoneDomainTestModule : AbpModule
{

}
