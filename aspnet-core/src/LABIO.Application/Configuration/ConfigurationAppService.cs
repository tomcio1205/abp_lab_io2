using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LABIO.Configuration.Dto;

namespace LABIO.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LABIOAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
