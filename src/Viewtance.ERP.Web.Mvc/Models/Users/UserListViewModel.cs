using System.Collections.Generic;
using Viewtance.ERP.Roles.Dto;
using Viewtance.ERP.Users.Dto;

namespace Viewtance.ERP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
