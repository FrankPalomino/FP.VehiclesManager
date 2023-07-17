using FP.VehiclesManager.Infrastructure.Contracts.Repositories;
using FP.VehiclesManager.Infrastructure.Impl.Contexts;
using FP.VehiclesManager.Infrastructure.Impl.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FP.VehiclesManager.Infrastructure.Impl.Extensions
{
    public static class InfrastructureServicesExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<VehiclesManagerDbContext>(options =>
            {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
                options.UseSqlServer(configuration.GetConnectionString("VehiclesManager"));
            });
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IVehicleRepository, VehicleRepository>();
            return services;
        }
    }
}
