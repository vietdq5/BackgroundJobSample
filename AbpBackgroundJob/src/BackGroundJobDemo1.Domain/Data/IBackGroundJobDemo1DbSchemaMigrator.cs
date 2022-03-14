using System.Threading.Tasks;

namespace BackGroundJobDemo1.Data;

public interface IBackGroundJobDemo1DbSchemaMigrator
{
    Task MigrateAsync();
}
