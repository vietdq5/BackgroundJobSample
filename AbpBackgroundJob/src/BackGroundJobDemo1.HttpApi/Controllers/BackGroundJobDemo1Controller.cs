using BackGroundJobDemo1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BackGroundJobDemo1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BackGroundJobDemo1Controller : AbpControllerBase
{
    protected BackGroundJobDemo1Controller()
    {
        LocalizationResource = typeof(BackGroundJobDemo1Resource);
    }
}
