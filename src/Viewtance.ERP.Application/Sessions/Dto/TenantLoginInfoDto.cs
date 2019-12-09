using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Viewtance.ERP.MultiTenancy;

namespace Viewtance.ERP.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
