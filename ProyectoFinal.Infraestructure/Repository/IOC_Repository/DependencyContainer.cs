using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Bill;
using ProyectoFinal.Core.Interfaces.IRepository.Brand;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
using ProyectoFinal.Core.Interfaces.IRepository.City;
using ProyectoFinal.Core.Interfaces.IRepository.Company;
using ProyectoFinal.Core.Interfaces.IRepository.Headquarter;
using ProyectoFinal.Core.Interfaces.IRepository.MethodPayment;
using ProyectoFinal.Core.Interfaces.IRepository.neighborhood;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;
using ProyectoFinal.Core.Interfaces.IRepository.Rol;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using ProyectoFinal.Core.Interfaces.IRepository.Warehouse;
using ProyectoFinal.Infraestructure.DataContext;
using ProyectoFinal.Infraestructure.Repository.Bill;
using ProyectoFinal.Infraestructure.Repository.Brand;
using ProyectoFinal.Infraestructure.Repository.Category;
using ProyectoFinal.Infraestructure.Repository.City;
using ProyectoFinal.Infraestructure.Repository.Company;
using ProyectoFinal.Infraestructure.Repository.Headquarters;
using ProyectoFinal.Infraestructure.Repository.MethodPayment;
using ProyectoFinal.Infraestructure.Repository.neighborhood;
using ProyectoFinal.Infraestructure.Repository.Products;
using ProyectoFinal.Infraestructure.Repository.Provider;
using ProyectoFinal.Infraestructure.Repository.Rol;
using ProyectoFinal.Infraestructure.Repository.Users;
using ProyectoFinal.Infraestructure.Repository.Warehouse;

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
            services.AddScoped<IMethodPaymentRepository, MethodPaymentRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IHeadquarterRepository, HeadquartersRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<INeighborhoodRepository, NeighborhoodRepository>();

            return services;
        }
    }
}
