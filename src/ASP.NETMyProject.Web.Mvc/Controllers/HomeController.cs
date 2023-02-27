using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ASP.NETMyProject.Controllers;

namespace ASP.NETMyProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NETMyProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
