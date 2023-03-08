using System.Threading.Tasks;
using ProjectDemo.Sessions.Dto;

namespace ProjectDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
