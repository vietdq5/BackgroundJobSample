using BackGroundJobDemo1.EntityFrameworkCore;
using System;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BackGroundJobDemo1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BackGroundJobDemo1EntityFrameworkCoreModule),
    typeof(BackGroundJobDemo1ApplicationContractsModule)
    )]
public class BackGroundJobDemo1DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}
