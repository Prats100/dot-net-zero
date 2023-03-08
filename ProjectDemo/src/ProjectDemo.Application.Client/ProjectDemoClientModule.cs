using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo
{
    public class ProjectDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoClientModule).GetAssembly());
        }
    }
}
