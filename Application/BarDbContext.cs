using Microsoft.EntityFrameworkCore;

namespace Application;

public class BarDbContext(DbContextOptions<BarDbContext> options) : DbContext(options)
{
    public DbSet<Table> Tables { get; set; }
}