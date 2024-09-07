using Microsoft.AspNetCore.Identity;
using TodoApp.Application.Enum;

namespace TodoApp.Persistence.Seeds
{
    public class DefaultRoles
    {
        public static List<IdentityRole> IdentityRoleList()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = Constants.Admin,
                    Name = Roles.Admin.ToString(),
                    NormalizedName = Roles.Admin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Constants.Moderator,
                    Name = Roles.Moderator.ToString(),
                    NormalizedName = Roles.Moderator.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Constants.User,
                    Name = Roles.User.ToString(),
                    NormalizedName = Roles.User.ToString().ToUpper()
                }
            };
        }
    }
}
