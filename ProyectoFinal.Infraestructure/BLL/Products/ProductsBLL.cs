using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Products;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Products
{
    public class ProductsBLL : IProductsBLL
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ILogService _LogService;

        public ProductsBLL (IProductsRepository productsRepository, ILogService logService)
        {
            _productsRepository = productsRepository;
            _LogService = logService;
        }

        public async Task<ResponseDTO> CreateProductBLL(CreateProductDTO products)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
              
                return await _productsRepository.CreateProducsRepository(products);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteProductBLL(int idProduct)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _productsRepository.DeleteProductsRepository(idProduct);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }

        }

        public async Task<ResponseDTO> GetProductsByIdBLL(int IdProducts)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _productsRepository.GetProductsByIdRepository(IdProducts);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetProductsBLL()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _productsRepository.GetProductsRepository();
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateProductBLL(ProductsDTO products)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _productsRepository.UpdateProductRepository(products);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

    }
}
