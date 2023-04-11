using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Udacity.DevOps.Capstone.Data;

/* This is used if database provider does't define
 * ICapstoneDbSchemaMigrator implementation.
 */
public class NullCapstoneDbSchemaMigrator : ICapstoneDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
