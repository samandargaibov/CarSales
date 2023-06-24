using CarSalesManagementDAL.Entities;

namespace CarSalesManagementDAL.Repositories.Contracts;

public interface IRepositoryAsync<T> where T : Entity
{
    Task<ICollection<T>> GetAllAsync();
    Task<T> GetByIdAsync(int? id);
    Task<T> AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    Task AddRangeAsync(params T[] entities);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);

}
