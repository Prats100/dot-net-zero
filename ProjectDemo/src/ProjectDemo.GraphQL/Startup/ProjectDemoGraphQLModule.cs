using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ProjectDemo.Startup
{
    [DependsOn(typeof(ProjectDemoCoreModule))]
    public class ProjectDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}