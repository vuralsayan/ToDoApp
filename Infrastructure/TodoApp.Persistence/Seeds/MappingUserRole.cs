using Microsoft.AspNetCore.Identity;
using TodoApp.Application.Enum;

namespace TodoApp.Persistence.Seeds
{
    public class MappingUserRole
    {
        public static List<IdentityUserRole<string>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = Constants.User,
                    UserId = Constants.BasicUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Admin,
                    UserId = Constants.AdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Moderator,
                    UserId = Constants.AdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.User,
                    UserId = Constants.AdminUser
                },
            };
        }
    }
}
