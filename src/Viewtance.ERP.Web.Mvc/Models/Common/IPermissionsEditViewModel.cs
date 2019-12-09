using System.Collections.Generic;
using Viewtance.ERP.Roles.Dto;

namespace Viewtance.ERP.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}