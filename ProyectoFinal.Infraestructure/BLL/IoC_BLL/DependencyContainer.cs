using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Core.Interfaces.IBLL.Bill;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using ProyectoFinal.Core.Interfaces.IBLL.City;
using ProyectoFinal.Core.Interfaces.IBLL.Company;
using ProyectoFinal.Core.Interfaces.IBLL.Headquarter;
using ProyectoFinal.Core.Interfaces.IBLL.MethodPayment;
using ProyectoFinal.Core.Interfaces.IBLL.Neighborhood;
using ProyectoFinal.Core.Interfaces.IBLL.Products;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;
using ProyectoFinal.Core.Interfaces.IBLL.Rol;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Warehouse;
using ProyectoFinal.Infraestructure.BLL.Bill;
using ProyectoFinal.Infraestructure.BLL.Brand;
using ProyectoFinal.Infraestructure.BLL.Category;
using ProyectoFinal.Infraestructure.BLL.City;
using ProyectoFinal.Infraestructure.BLL.Company;
using ProyectoFinal.Infraestructure.BLL.Headquarters;
using ProyectoFinal.Infraestructure.BLL.MethodPayment;
using ProyectoFinal.Infraestructure.BLL.Neighborhood;
using ProyectoFinal.Infraestructure.BLL.Products;
using ProyectoFinal.Infraestructure.BLL.Provider;
using ProyectoFinal.Infraestructure.BLL.Rol;
using ProyectoFinal.Infraestructure.BLL.Users;
using ProyectoFinal.Infraestructure.BLL.Warehouse;

namespace ProyectoFinal.Infraestructure.BLL.IoC_BLL
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBll(this IServiceCollection services)
        {
            services.AddScoped<IBrandBLL,  BrandBLL>();
            services.AddScoped<ICategoryBLL, CategoryBLL>();
            services.AddScoped<IProductsBLL, ProductsBLL>();
            services.AddScoped<IProviderBLL, ProviderBLL>();
            services.AddScoped<IRolBLL, RolBLL>();
            services.AddScoped<IUserBLL, UsersBLL>();
            services.AddScoped<ICompanyBLL, CompanyBLL>();
            services.AddScoped<IMethodPaymentBLL, MethodPaymentBLL>();
            services.AddScoped<IBillBLL, BillBLL>();
            services.AddScoped<IHeadquarterBLL, HeadquartersBLL>();
            services.AddScoped<IWarehouseBLL, WarehouseBLL>();
            services.AddScoped<ICitiesBLL, CitiesBLL>();
            services.AddScoped<INeighborhoodBLL, NeighborhoodBLL>();

            return services;
        }

    }
}
