using System.Threading.Tasks;
using Abp.Application.Services;
using HuyWebStore.Authorization.Accounts.Dto;

namespace HuyWebStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
