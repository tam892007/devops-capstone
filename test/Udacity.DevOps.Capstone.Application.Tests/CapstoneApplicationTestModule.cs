using Volo.Abp.Modularity;

namespace Udacity.DevOps.Capstone;

[DependsOn(
    typeof(CapstoneApplicationModule),
    typeof(CapstoneDomainTestModule)
    )]
public class CapstoneApplicationTestModule : AbpModule
{

}
