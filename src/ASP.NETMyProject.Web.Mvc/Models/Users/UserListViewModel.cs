using System.Collections.Generic;
using ASP.NETMyProject.Roles.Dto;

namespace ASP.NETMyProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
