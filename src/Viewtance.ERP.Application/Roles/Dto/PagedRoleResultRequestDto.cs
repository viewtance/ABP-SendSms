using Abp.Application.Services.Dto;

namespace Viewtance.ERP.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

