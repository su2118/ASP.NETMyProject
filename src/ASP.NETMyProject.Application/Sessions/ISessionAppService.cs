using System.Threading.Tasks;
using Abp.Application.Services;
using ASP.NETMyProject.Sessions.Dto;

namespace ASP.NETMyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
