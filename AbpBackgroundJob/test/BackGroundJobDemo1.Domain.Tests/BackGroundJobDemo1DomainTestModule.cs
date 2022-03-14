using BackGroundJobDemo1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BackGroundJobDemo1;

[DependsOn(
    typeof(BackGroundJobDemo1EntityFrameworkCoreTestModule)
    )]
public class BackGroundJobDemo1DomainTestModule : AbpModule
{

}
