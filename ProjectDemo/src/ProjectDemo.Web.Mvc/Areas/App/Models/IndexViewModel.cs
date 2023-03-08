using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace ProjectDemo.Web.Areas.App.Models
{
    [AutoMapFrom(typeof(ListResultDto<PersonListDto>))]
    public class IndexViewModel : ListResultDto<PersonListDto>
    {
        public string Filter { get; set; }
    }
}
