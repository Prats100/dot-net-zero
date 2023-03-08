using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Controllers;

namespace ProjectDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : ProjectDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}