using System.Linq;
using EmptyWeb.Model;

namespace EmptyWeb.Busines
{
    public static class DbIniter
    {
        public static void Initialize(UsersContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            SiteUser user1 = new SiteUser() { Age = 16, Name = "Kekus" };
            SiteUser user2 = new SiteUser() { Age = 18, Name = "Shpekus" };
            SiteUser user3 = new SiteUser() { Age = 25, Name = "Msximus" };

            context.Users.AddRange(user1, user2, user3);
            context.SaveChanges();
        }
    }
}