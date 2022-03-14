using System;
using System.Collections.Generic;
using System.Text;
using BackGroundJobDemo1.Localization;
using Volo.Abp.Application.Services;

namespace BackGroundJobDemo1;

/* Inherit your application services from this class.
 */
public abstract class BackGroundJobDemo1AppService : ApplicationService
{
    protected BackGroundJobDemo1AppService()
    {
        LocalizationResource = typeof(BackGroundJobDemo1Resource);
    }
}
