using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    [DependsOn(typeof(ProjectDemoCoreSharedModule))]
    public class ProjectDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoApplicationSharedModule).GetAssembly());
        }
    }
}