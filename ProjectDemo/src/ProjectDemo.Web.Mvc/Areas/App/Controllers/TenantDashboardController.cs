using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Authorization;
using ProjectDemo.DashboardCustomization;
using System.Threading.Tasks;
using ProjectDemo.Web.Areas.App.Startup;

namespace ProjectDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(ProjectDemoDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}