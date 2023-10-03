using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using ProyectoFinal.Core.Interfaces.IBLL.Products;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;
using ProyectoFinal.Core.Interfaces.IBLL.Rol;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.Infraestructure.BLL.Brand;
using ProyectoFinal.Infraestructure.BLL.Category;
using ProyectoFinal.Infraestructure.BLL.Products;
using ProyectoFinal.Infraestructure.BLL.Provider;
using ProyectoFinal.Infraestructure.BLL.Rol;
using ProyectoFinal.Infraestructure.BLL.Users;

namespace ProyectoFinal.Infraestructure.BLL.IoC_BLL
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBll(this IServiceCollection services)
        {
            services.AddScoped< IBrandBLL,  BrandBLL>();
            services.AddScoped<ICategoryBLL, CategoryBLL>();
            services.AddScoped<IProductsBLL, ProductsBLL>();
            services.AddScoped<IProviderBLL, ProviderBLL>();
            services.AddScoped<IRolBLL, RolBLL>();
            services.AddScoped<IUserBLL, UsersBLL>();

            return services;
        }

    }
}
