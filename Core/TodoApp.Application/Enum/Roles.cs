namespace TodoApp.Application.Enum
{
    public enum Roles
    {
        Admin,
        Moderator,
        User
    }

    public static class Constants
    {
        public static readonly string Admin = Guid.NewGuid().ToString();
        public static readonly string Moderator = Guid.NewGuid().ToString();
        public static readonly string User = Guid.NewGuid().ToString();

        public static readonly string AdminUser = Guid.NewGuid().ToString();
        public static readonly string BasicUser = Guid.NewGuid().ToString();
    }
}
