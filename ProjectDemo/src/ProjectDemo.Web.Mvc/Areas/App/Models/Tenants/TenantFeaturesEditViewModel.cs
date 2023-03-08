using Abp.AutoMapper;
using ProjectDemo.MultiTenancy;
using ProjectDemo.MultiTenancy.Dto;
using ProjectDemo.Web.Areas.App.Models.Common;

namespace ProjectDemo.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}