using Abp.Authorization;
using ProjectDemo.Authorization.Roles;
using ProjectDemo.Authorization.Users;

namespace ProjectDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
