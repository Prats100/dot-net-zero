using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models.Layout;
using ProjectDemo.Web.Session;
using ProjectDemo.Web.Views;

namespace ProjectDemo.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : ProjectDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
