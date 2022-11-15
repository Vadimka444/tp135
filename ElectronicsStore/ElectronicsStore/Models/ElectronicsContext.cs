using Microsoft.EntityFrameworkCore;

namespace ElectronicsStore.Models
{
    public class ElectronicsContext : DbContext
    {
        public DbSet<Electronics> Electronics { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ElectronicsContext(DbContextOptions<ElectronicsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
