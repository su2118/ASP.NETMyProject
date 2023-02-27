using Abp.Application.Services;
using ASP.NETMyProject.MultiTenancy.Dto;

namespace ASP.NETMyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

