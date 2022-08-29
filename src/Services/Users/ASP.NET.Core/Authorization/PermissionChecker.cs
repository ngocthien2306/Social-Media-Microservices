using Abp.Authorization;
using ASP.NET.Authorization.Roles;
using ASP.NET.Authorization.Users;

namespace ASP.NET.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
