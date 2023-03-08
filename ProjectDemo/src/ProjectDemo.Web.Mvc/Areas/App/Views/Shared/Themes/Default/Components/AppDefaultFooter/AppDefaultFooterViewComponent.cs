using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models.Layout;
using ProjectDemo.Web.Session;
using ProjectDemo.Web.Views;

namespace ProjectDemo.Web.Areas.App.Views.Shared.Themes.Default.Components.AppDefaultFooter
{
    public class AppDefaultFooterViewComponent : ProjectDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppDefaultFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
