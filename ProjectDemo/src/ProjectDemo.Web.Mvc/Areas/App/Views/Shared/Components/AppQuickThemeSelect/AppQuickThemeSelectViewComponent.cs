using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models.Layout;
using ProjectDemo.Web.Views;

namespace ProjectDemo.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : ProjectDemoViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
