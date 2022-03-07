using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiteManagement.Application.Contracts.Persistence.Repositories.Commons;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Infrastructure.Contracts.Repositories.Commons;
using SiteManagement.Infrastructure.Contracts.Repositories.Contracts;

namespace SiteManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<Contracts.Repositories.AppDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IFlatRepository, FlatRepository>();
            services.AddScoped<IFlatOfUserRepository, FlatOfUserRepository>();
            services.AddScoped<IFeeRepository, FeeRepository>();
            services.AddScoped<IBillRepository, BillRepository>();


            return services;
        }
    }
}
