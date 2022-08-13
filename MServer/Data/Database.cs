using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MServer.Data;

namespace ManolisShop
{
    internal class Database : IdentityDbContext<User,Role,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=manolishop.db3");
        }

        public DbSet<Order> Orders{ get; set; }
        public DbSet<Product> Products { get; set; }

        //   public DbSet<User> Users{ get; set; }

    }
}
