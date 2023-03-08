using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.Install.Dto;

namespace ProjectDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}