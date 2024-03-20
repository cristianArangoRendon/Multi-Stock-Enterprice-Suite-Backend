using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Infraestructure.BLL.IoC_BLL;
using ProyectoFinal.Infraestructure.Repository.IOC_Repository;
using ProyectoFinal.Infraestructure.Services.LogService;

namespace ProyectoFinal.Infraestructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection

        AddProyectoFinal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBll();
            
            services.AddRepository();

            services.AddServices();

            return services;
        }
    }
}
