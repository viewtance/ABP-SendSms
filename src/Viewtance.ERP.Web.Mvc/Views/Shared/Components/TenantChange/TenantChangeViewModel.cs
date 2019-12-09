using Abp.AutoMapper;
using Viewtance.ERP.Sessions.Dto;

namespace Viewtance.ERP.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
