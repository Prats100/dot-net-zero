using System.Collections.Generic;
using ProjectDemo.Editions;
using ProjectDemo.Editions.Dto;
using ProjectDemo.MultiTenancy.Payments;
using ProjectDemo.MultiTenancy.Payments.Dto;

namespace ProjectDemo.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
