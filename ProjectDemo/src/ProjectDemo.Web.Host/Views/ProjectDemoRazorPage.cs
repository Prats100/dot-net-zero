using Abp.AspNetCore.Mvc.Views;

namespace ProjectDemo.Web.Views
{
    public abstract class ProjectDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ProjectDemoRazorPage()
        {
            LocalizationSourceName = ProjectDemoConsts.LocalizationSourceName;
        }
    }
}
