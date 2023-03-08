using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.Editions.Dto;
using ProjectDemo.MultiTenancy.Dto;

namespace ProjectDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}