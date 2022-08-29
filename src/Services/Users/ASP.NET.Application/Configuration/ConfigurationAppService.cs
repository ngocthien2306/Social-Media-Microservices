using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASP.NET.Configuration.Dto;

namespace ASP.NET.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NETAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
