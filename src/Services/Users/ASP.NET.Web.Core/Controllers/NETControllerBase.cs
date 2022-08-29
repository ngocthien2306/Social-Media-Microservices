using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET.Controllers
{
    public abstract class NETControllerBase: AbpController
    {
        protected NETControllerBase()
        {
            LocalizationSourceName = NETConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
