using Abp.MultiTenancy;
using ASP.NETMyProject.Authorization.Users;

namespace ASP.NETMyProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
