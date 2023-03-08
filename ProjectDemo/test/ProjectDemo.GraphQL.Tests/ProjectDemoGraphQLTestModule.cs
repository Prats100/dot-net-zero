using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ProjectDemo.Configure;
using ProjectDemo.Startup;
using ProjectDemo.Test.Base;

namespace ProjectDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(ProjectDemoGraphQLModule),
        typeof(ProjectDemoTestBaseModule))]
    public class ProjectDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoGraphQLTestModule).GetAssembly());
        }
    }
}