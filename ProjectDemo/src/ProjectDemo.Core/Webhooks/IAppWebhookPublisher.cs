using System.Threading.Tasks;
using ProjectDemo.Authorization.Users;

namespace ProjectDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
