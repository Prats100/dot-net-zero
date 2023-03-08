using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.Configuration.Tenants.Dto;

namespace ProjectDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
