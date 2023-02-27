using Abp.AutoMapper;
using ASP.NETMyProject.Sessions.Dto;

namespace ASP.NETMyProject.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
