using CarSalesManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarSalesManagementDAL.DataContext;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Car>? Cars { get; set; }
}
