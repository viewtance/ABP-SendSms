using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Viewtance.ERP.MultiTenancy.Dto;

namespace Viewtance.ERP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

