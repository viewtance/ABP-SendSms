using Abp.Authorization;
using Viewtance.ERP.Authorization.Roles;
using Viewtance.ERP.Authorization.Users;

namespace Viewtance.ERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
