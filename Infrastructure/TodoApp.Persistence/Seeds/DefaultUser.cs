using TodoApp.Application.Auth;
using TodoApp.Application.Enum;

namespace TodoApp.Persistence.Seeds
{
    public class DefaultUser
    {
        public static List<ApplicationUser> IdentityBasicUserList()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = Constants.AdminUser,
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "ADMIN@GMAIL.COM",
                    NormalizedUserName="ADMIN"
                },
                new ApplicationUser
                {
                    Id = Constants.BasicUser,
                    UserName = "user",
                    Email = "user@gmail.com",
                    FirstName = "User",
                    LastName = "User",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "USER@GMAIL.COM",
                    NormalizedUserName="USER"
                },
            };
        }
    }
}
