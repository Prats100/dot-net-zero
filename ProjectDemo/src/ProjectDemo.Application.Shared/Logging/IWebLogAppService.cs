using Abp.Application.Services;
using ProjectDemo.Dto;
using ProjectDemo.Logging.Dto;

namespace ProjectDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
