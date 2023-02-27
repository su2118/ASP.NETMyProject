using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASP.NETMyProject.Configuration.Dto;

namespace ASP.NETMyProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NETMyProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
