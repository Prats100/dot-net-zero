using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models.Layout;
using ProjectDemo.Web.Session;
using ProjectDemo.Web.Views;

namespace ProjectDemo.Web.Areas.App.Views.Shared.Themes.Theme11.Components.AppTheme11Footer
{
    public class AppTheme11FooterViewComponent : ProjectDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme11FooterViewComponent(IPerRequestSessionCache sessionCache)
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
