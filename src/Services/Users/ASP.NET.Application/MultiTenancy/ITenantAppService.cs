using Abp.Application.Services;
using ASP.NET.MultiTenancy.Dto;

namespace ASP.NET.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

