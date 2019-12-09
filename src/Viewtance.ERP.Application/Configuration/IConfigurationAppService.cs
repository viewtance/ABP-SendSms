using System.Threading.Tasks;
using Viewtance.ERP.Configuration.Dto;

namespace Viewtance.ERP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
