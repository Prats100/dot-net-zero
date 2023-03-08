﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ProjectDemo.Authorization.Permissions.Dto;
using ProjectDemo.Web.Areas.App.Models.Common;

namespace ProjectDemo.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}