using Volo.Abp.Modularity;

namespace BackGroundJobDemo1;

[DependsOn(
    typeof(BackGroundJobDemo1ApplicationModule),
    typeof(BackGroundJobDemo1DomainTestModule)
    )]
public class BackGroundJobDemo1ApplicationTestModule : AbpModule
{

}
