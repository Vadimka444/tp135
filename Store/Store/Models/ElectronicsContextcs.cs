using Microsoft.EntityFrameworkCore;

namespace Store.Models;

public class ElectronicsContext : DbContext
{
    public ElectronicsContext(DbContextOptions<ElectronicsContext> options)
        : base(options)
    {
    }

    public DbSet<Electronics> Electronics { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
}

