using Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Food> foods { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}