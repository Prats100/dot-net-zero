using Abp.Domain.Services;

namespace ProjectDemo
{
    public abstract class ProjectDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ProjectDemoDomainServiceBase()
        {
            LocalizationSourceName = ProjectDemoConsts.LocalizationSourceName;
        }
    }
}
