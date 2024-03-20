using ActiveDirectoryBack.Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Services.LogService
{

    public static class DependencyContainer
      { 
            public static IServiceCollection AddServices(this IServiceCollection services)
            {
                services.AddScoped<ILogService, LogService>();
               

            return services;
            }
        }
}
