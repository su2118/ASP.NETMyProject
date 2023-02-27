using Abp.AspNetCore.Mvc.ViewComponents;

namespace ASP.NETMyProject.Web.Views
{
    public abstract class NETMyProjectViewComponent : AbpViewComponent
    {
        protected NETMyProjectViewComponent()
        {
            LocalizationSourceName = NETMyProjectConsts.LocalizationSourceName;
        }
    }
}
