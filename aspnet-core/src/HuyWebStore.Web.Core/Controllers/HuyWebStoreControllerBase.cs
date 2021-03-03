using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HuyWebStore.Controllers
{
    public abstract class HuyWebStoreControllerBase: AbpController
    {
        protected HuyWebStoreControllerBase()
        {
            LocalizationSourceName = HuyWebStoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
