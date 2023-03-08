using Abp.Auditing;
using ProjectDemo.Configuration.Dto;

namespace ProjectDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}