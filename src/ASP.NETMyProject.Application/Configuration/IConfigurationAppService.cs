using System.Threading.Tasks;
using ASP.NETMyProject.Configuration.Dto;

namespace ASP.NETMyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
