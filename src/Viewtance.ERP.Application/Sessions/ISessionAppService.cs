using System.Threading.Tasks;
using Abp.Application.Services;
using Viewtance.ERP.Sessions.Dto;

namespace Viewtance.ERP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
