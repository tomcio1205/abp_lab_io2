using Abp.Application.Services;
using LABIO.MultiTenancy.Dto;

namespace LABIO.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

