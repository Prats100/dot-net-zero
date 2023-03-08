using ProjectDemo.Editions;
using ProjectDemo.Editions.Dto;
using ProjectDemo.MultiTenancy.Payments;
using ProjectDemo.Security;
using ProjectDemo.MultiTenancy.Payments.Dto;

namespace ProjectDemo.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
