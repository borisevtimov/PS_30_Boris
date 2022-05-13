using System.Data.Entity;

namespace UserLogin
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Log> Logs { get; set; }

        public UserContext()
            : base("Data Source=BORISPC;Initial Catalog=ConsoleApp;Integrated Security=True")
        {

        }
    }
}
