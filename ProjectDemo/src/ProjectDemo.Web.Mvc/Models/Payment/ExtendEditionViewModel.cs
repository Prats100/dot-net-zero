using System.Collections.Generic;
using ProjectDemo.Editions.Dto;
using ProjectDemo.MultiTenancy.Payments;

namespace ProjectDemo.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}