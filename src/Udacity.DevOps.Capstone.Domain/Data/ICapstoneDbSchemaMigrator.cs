using System.Threading.Tasks;

namespace Udacity.DevOps.Capstone.Data;

public interface ICapstoneDbSchemaMigrator
{
    Task MigrateAsync();
}
