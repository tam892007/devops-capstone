using Udacity.DevOps.Capstone.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Udacity.DevOps.Capstone.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CapstoneEntityFrameworkCoreModule),
    typeof(CapstoneApplicationContractsModule)
    )]
public class CapstoneDbMigratorModule : AbpModule
{

}
