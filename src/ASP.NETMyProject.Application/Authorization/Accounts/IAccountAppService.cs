using System.Threading.Tasks;
using Abp.Application.Services;
using ASP.NETMyProject.Authorization.Accounts.Dto;

namespace ASP.NETMyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
