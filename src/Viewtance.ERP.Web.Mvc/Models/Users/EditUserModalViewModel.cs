using System.Collections.Generic;
using System.Linq;
using Viewtance.ERP.Roles.Dto;
using Viewtance.ERP.Users.Dto;

namespace Viewtance.ERP.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
