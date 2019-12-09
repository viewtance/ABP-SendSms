using System.Collections.Generic;
using Viewtance.ERP.Roles.Dto;

namespace Viewtance.ERP.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
