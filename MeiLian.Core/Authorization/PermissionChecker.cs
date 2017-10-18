using Abp.Authorization;
using MeiLian.Authorization.Roles;
using MeiLian.Authorization.Users;
using MeiLian.MultiTenancy;

namespace MeiLian.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

