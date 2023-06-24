using CarSalesManagementDAL.Repositories;
using CarSalesManagementDAL.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CarSalesManagementDAL;

public static class DataAccessLayerServiceRegistration
{
    public static IServiceCollection AddDalServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepositoryAsync<>),typeof(EfCoreRepository<>));
        services.AddScoped<IBrandRepository,BrandRepository>();

        return services;
    }
}
