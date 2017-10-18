using System.Collections.Generic;
using MeiLian.Authorization.Permissions.Dto;

namespace MeiLian.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}
