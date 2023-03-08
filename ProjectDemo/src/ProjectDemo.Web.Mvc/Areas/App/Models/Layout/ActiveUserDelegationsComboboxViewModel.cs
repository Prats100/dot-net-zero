using System.Collections.Generic;
using ProjectDemo.Authorization.Delegation;
using ProjectDemo.Authorization.Users.Delegation.Dto;

namespace ProjectDemo.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
