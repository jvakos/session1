using Microsoft.EntityFrameworkCore;

namespace ManolisShop
{
    internal class Database : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=manolishop.db3");
        }

        public DbSet<Order> Orders{ get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
