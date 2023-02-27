using System.Collections.Generic;
using ASP.NETMyProject.Roles.Dto;

namespace ASP.NETMyProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
