using Abp.AutoMapper;
using ProjectDemo.Authorization.Roles.Dto;
using ProjectDemo.Web.Areas.App.Models.Common;

namespace ProjectDemo.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}