using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Viewtance.ERP.Configuration.Dto;

namespace Viewtance.ERP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ERPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
