using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BackGroundJobDemo1.Data;

/* This is used if database provider does't define
 * IBackGroundJobDemo1DbSchemaMigrator implementation.
 */
public class NullBackGroundJobDemo1DbSchemaMigrator : IBackGroundJobDemo1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
