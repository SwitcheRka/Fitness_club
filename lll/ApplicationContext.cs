using System;
using Microsoft.EntityFrameworkCore;

namespace lll
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Users> users { get; set; } = null!;
        public DbSet<product> product { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;DataBase=postgres;Username=postgres;Password=oooMaxooo2005");
        }
    }
}