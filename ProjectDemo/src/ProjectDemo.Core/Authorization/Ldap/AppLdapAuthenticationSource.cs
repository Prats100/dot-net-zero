using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using ProjectDemo.Authorization.Users;
using ProjectDemo.MultiTenancy;

namespace ProjectDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}