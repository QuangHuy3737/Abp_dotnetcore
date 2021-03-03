using System.Threading.Tasks;
using HuyWebStore.Configuration.Dto;

namespace HuyWebStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
