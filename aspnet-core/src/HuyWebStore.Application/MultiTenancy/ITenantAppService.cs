using Abp.Application.Services;
using HuyWebStore.MultiTenancy.Dto;

namespace HuyWebStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

