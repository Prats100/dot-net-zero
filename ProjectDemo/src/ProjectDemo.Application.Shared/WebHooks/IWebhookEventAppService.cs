using System.Threading.Tasks;
using Abp.Webhooks;

namespace ProjectDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
