using Microsoft.EntityFrameworkCore;

namespace Application;

public class BarDbContext : DbContext
{
    public DbSet<Table> Tables { get; set; }
}