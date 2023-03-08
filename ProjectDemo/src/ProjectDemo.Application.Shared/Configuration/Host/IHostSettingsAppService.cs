using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.Configuration.Host.Dto;

namespace ProjectDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
