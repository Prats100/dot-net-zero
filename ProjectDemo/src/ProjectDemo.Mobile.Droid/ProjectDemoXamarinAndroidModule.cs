using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    [DependsOn(typeof(ProjectDemoXamarinSharedModule))]
    public class ProjectDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoXamarinAndroidModule).GetAssembly());
        }
    }
}