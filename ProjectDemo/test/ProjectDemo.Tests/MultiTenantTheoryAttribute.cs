using Xunit;

namespace ProjectDemo.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        private readonly bool _multiTenancyEnabled = ProjectDemoConsts.MultiTenancyEnabled;
      
        public MultiTenantTheoryAttribute()
        {
            if (!_multiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}