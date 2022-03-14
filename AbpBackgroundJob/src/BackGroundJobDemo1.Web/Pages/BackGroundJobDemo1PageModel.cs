using BackGroundJobDemo1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BackGroundJobDemo1.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BackGroundJobDemo1PageModel : AbpPageModel
{
    protected BackGroundJobDemo1PageModel()
    {
        LocalizationResourceType = typeof(BackGroundJobDemo1Resource);
    }
}
