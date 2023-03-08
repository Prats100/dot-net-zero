using Abp.AutoMapper;
using ProjectDemo.MultiTenancy.Dto;

namespace ProjectDemo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
