using Abp.AutoMapper;

namespace ProjectDemo.Web.Areas.App.Models
{
    [AutoMapFrom(typeof(GetPersonForEditOutput))]
    public class EditPersonModalViewModel:GetPersonForEditOutput
    {
    }
}
