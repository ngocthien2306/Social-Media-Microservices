using System.Threading.Tasks;
using ASP.NET.Configuration.Dto;

namespace ASP.NET.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
