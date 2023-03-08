using System.Collections.Generic;
using ProjectDemo.Authorization.Permissions.Dto;

namespace ProjectDemo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}