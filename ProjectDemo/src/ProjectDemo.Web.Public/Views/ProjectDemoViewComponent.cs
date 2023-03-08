using Abp.AspNetCore.Mvc.ViewComponents;

namespace ProjectDemo.Web.Public.Views
{
    public abstract class ProjectDemoViewComponent : AbpViewComponent
    {
        protected ProjectDemoViewComponent()
        {
            LocalizationSourceName = ProjectDemoConsts.LocalizationSourceName;
        }
    }
}