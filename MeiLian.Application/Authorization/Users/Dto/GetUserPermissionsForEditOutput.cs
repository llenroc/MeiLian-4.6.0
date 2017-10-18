using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Authorization.Permissions.Dto;

namespace MeiLian.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
