using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace ProjectDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
