using Abp.AutoMapper;
using Viewtance.ERP.Roles.Dto;
using Viewtance.ERP.Web.Models.Common;

namespace Viewtance.ERP.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
