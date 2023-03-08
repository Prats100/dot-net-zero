using Abp.AutoMapper;
using ProjectDemo.Authorization.Users;
using ProjectDemo.Authorization.Users.Dto;
using ProjectDemo.Web.Areas.App.Models.Common;

namespace ProjectDemo.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}