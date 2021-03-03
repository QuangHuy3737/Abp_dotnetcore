using Abp.Authorization;
using HuyWebStore.Authorization.Roles;
using HuyWebStore.Authorization.Users;

namespace HuyWebStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
