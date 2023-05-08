using System.Threading.Tasks;
using LABIO.Configuration.Dto;

namespace LABIO.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
