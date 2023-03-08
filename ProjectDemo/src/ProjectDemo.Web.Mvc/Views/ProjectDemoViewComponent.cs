using Abp.AspNetCore.Mvc.ViewComponents;

namespace ProjectDemo.Web.Views
{
    public abstract class ProjectDemoViewComponent : AbpViewComponent
    {
        protected ProjectDemoViewComponent()
        {
            LocalizationSourceName = ProjectDemoConsts.LocalizationSourceName;
        }
    }
}