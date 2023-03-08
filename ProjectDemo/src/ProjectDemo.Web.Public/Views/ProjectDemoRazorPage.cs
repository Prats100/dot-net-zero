using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ProjectDemo.Web.Public.Views
{
    public abstract class ProjectDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ProjectDemoRazorPage()
        {
            LocalizationSourceName = ProjectDemoConsts.LocalizationSourceName;
        }
    }
}
