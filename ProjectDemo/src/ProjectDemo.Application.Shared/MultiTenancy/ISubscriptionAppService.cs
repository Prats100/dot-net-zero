using System.Threading.Tasks;
using Abp.Application.Services;

namespace ProjectDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
