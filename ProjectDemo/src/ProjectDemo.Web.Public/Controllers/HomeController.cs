using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Controllers;

namespace ProjectDemo.Web.Public.Controllers
{
    public class HomeController : ProjectDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}