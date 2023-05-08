using Abp.Authorization;
using LABIO.Authorization.Roles;
using LABIO.Authorization.Users;

namespace LABIO.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
