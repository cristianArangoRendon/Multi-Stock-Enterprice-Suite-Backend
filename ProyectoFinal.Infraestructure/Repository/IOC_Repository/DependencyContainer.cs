using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Brand;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
using ProyectoFinal.Core.Interfaces.IRepository.Company;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;
using ProyectoFinal.Core.Interfaces.IRepository.Rol;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using ProyectoFinal.Infraestructure.DataContext;
using ProyectoFinal.Infraestructure.Repository.Brand;
using ProyectoFinal.Infraestructure.Repository.Category;
using ProyectoFinal.Infraestructure.Repository.Company;
using ProyectoFinal.Infraestructure.Repository.Products;
using ProyectoFinal.Infraestructure.Repository.Provider;
using ProyectoFinal.Infraestructure.Repository.Rol;
using ProyectoFinal.Infraestructure.Repository.Users;

namespace ProyectoFinal.Infraestructure.Repository.IOC_Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDataContextProyectoFinal, ProyectoFinalDataContext>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IRolRepository, RolRepository>();
            services.AddScoped<IUsersRepository, UserRepository>();
            services.AddScoped<ICompanyRepository,CompanyRepository>();

            return services;
        }
    }
}
