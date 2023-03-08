using Microsoft.Extensions.Configuration;

namespace ProjectDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
