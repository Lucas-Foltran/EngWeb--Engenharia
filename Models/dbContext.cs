using Microsoft.EntityFrameworkCore;

namespace Site2.Models
{
    public class dbContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ESoftware;Trusted_Connection=True;");
        }
    }
}
