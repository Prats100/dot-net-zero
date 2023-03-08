using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Authorization;
using ProjectDemo.DashboardCustomization;
using System.Threading.Tasks;
using ProjectDemo.Web.Areas.App.Startup;

namespace ProjectDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(ProjectDemoDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}