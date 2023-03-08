using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ProjectDemo.Editions.Dto;

namespace ProjectDemo.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}