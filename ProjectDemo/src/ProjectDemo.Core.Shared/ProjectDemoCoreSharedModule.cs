using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    public class ProjectDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoCoreSharedModule).GetAssembly());
        }
    }
}