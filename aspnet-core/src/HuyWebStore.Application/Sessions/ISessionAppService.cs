using System.Threading.Tasks;
using Abp.Application.Services;
using HuyWebStore.Sessions.Dto;

namespace HuyWebStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
