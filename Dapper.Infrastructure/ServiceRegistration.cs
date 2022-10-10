using Dapper.Application.Interfaces;
using Dapper.Infrastructure.Context;
using Dapper.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Infrastructure
{
    public static class ServiceRegistration
    {
       public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

        }
    }
}
