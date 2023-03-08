using Abp.Modules;
using ProjectDemo.Test.Base;

namespace ProjectDemo.Tests
{
    [DependsOn(typeof(ProjectDemoTestBaseModule))]
    public class ProjectDemoTestModule : AbpModule
    {
       
    }
}
