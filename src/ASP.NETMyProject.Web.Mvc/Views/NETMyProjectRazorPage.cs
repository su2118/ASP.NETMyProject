using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ASP.NETMyProject.Web.Views
{
    public abstract class NETMyProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected NETMyProjectRazorPage()
        {
            LocalizationSourceName = NETMyProjectConsts.LocalizationSourceName;
        }
    }
}
