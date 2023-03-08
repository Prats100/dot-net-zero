using System.Threading.Tasks;
using Abp.Authorization.Users;
using ProjectDemo.Authorization.Users;

namespace ProjectDemo.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
