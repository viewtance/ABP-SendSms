using Abp.MultiTenancy;
using Viewtance.ERP.Authorization.Users;

namespace Viewtance.ERP.MultiTenancy
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
