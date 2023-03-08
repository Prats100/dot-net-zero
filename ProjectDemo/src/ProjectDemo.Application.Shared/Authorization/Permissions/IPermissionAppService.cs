using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ProjectDemo.Authorization.Permissions.Dto;

namespace ProjectDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
