using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using ProjectDemo.Configuration;

namespace ProjectDemo.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(ProjectDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
