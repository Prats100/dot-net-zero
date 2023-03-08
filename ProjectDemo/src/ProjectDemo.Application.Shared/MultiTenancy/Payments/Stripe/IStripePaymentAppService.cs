using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.MultiTenancy.Payments.Dto;
using ProjectDemo.MultiTenancy.Payments.Stripe.Dto;

namespace ProjectDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}