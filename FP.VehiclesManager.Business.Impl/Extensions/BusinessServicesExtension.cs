using FP.VehiclesManager.Business.Contracts.Services;
using FP.VehiclesManager.Business.Impl.Services;
using FP.VehiclesManager.Infrastructure.Impl.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FP.VehiclesManager.Business.Impl.Extensions
{
    public static class BusinessServicesExtension
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructureServices(configuration);
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IVehicleService, VehicleService>();
            return services;
        }
    }
}
