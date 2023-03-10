using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjectDemo.Authorization;
using System;

namespace ProjectDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ProjectDemoApplicationSharedModule),
        typeof(ProjectDemoCoreModule)
        )]
    public class ProjectDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);

    
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoApplicationModule).GetAssembly());
        }
    }
}