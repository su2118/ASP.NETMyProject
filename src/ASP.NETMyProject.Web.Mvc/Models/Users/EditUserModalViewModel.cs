using System.Collections.Generic;
using System.Linq;
using ASP.NETMyProject.Roles.Dto;
using ASP.NETMyProject.Users.Dto;

namespace ASP.NETMyProject.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
