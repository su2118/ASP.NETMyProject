using System.Collections.Generic;
using ASP.NETMyProject.Roles.Dto;

namespace ASP.NETMyProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}