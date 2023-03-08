using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.Sessions.Dto;

namespace ProjectDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
