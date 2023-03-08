using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models.Layout;
using ProjectDemo.Web.Views;

namespace ProjectDemo.Web.Areas.App.Views.Shared.Components.AppRecentNotifications
{
    public class AppRecentNotificationsViewComponent : ProjectDemoViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
