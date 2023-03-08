﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDemo.MultiTenancy.Payments.PayPal.Dto;

namespace ProjectDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
