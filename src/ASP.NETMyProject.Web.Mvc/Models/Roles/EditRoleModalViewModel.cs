using Abp.AutoMapper;
using ASP.NETMyProject.Roles.Dto;
using ASP.NETMyProject.Web.Models.Common;

namespace ASP.NETMyProject.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
