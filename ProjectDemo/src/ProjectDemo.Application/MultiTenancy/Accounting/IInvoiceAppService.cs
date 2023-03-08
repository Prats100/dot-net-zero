using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ProjectDemo.MultiTenancy.Accounting.Dto;

namespace ProjectDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
