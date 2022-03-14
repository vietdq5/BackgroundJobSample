using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BackGroundJobDemo1.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BackGroundJobDemo1DbContextFactory : IDesignTimeDbContextFactory<BackGroundJobDemo1DbContext>
{
    public BackGroundJobDemo1DbContext CreateDbContext(string[] args)
    {
        BackGroundJobDemo1EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BackGroundJobDemo1DbContext>()
            .UseNpgsql(configuration.GetConnectionString("Default"));

        return new BackGroundJobDemo1DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BackGroundJobDemo1.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
