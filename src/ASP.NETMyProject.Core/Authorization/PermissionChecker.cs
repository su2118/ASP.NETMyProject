using Abp.Authorization;
using ASP.NETMyProject.Authorization.Roles;
using ASP.NETMyProject.Authorization.Users;

namespace ASP.NETMyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
