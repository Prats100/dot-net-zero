using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Controllers;

namespace ProjectDemo.Web.Public.Controllers
{
    public class AboutController : ProjectDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}