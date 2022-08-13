using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ManolisShop
{
    internal class Database : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=manolishop.db3");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        public DbSet<Order> Orders{ get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
