using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LABIO.Controllers
{
    public abstract class LABIOControllerBase: AbpController
    {
        protected LABIOControllerBase()
        {
            LocalizationSourceName = LABIOConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
