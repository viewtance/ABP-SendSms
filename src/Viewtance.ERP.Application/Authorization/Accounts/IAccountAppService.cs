using System.Threading.Tasks;
using Abp.Application.Services;
using Viewtance.ERP.Authorization.Accounts.Dto;

namespace Viewtance.ERP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
