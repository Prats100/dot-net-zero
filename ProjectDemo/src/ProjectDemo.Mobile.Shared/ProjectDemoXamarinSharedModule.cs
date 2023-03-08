using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    [DependsOn(typeof(ProjectDemoClientModule), typeof(AbpAutoMapperModule))]
    public class ProjectDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoXamarinSharedModule).GetAssembly());
        }
    }
}