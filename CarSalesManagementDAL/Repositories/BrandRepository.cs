using CarSalesManagementDAL.DataContext;
using CarSalesManagementDAL.Entities;
using CarSalesManagementDAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CarSalesManagementDAL.Repositories;

public class BrandRepository : EfCoreRepository<Brand>, IBrandRepository
{
    private readonly AppDbContext _dbContext;
    public BrandRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<ICollection<Brand>> GetAllAsync()
    {
        var result = await _dbContext.Brands.Include(b => b.Cars).ToListAsync();

        return result;
    }
}
