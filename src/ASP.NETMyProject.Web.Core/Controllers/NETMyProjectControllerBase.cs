using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASP.NETMyProject.Controllers
{
    public abstract class NETMyProjectControllerBase: AbpController
    {
        protected NETMyProjectControllerBase()
        {
            LocalizationSourceName = NETMyProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
