using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    [DependsOn(typeof(ProjectDemoXamarinSharedModule))]
    public class ProjectDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoXamarinIosModule).GetAssembly());
        }
    }
}