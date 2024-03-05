using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Products;
using ProyectoFinal.Core.Interfaces.IRepository.Products;

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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll CreateProducsRepository: " + ex.Message);
                response.Message += ex.ToString();
                return response;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll DeleteProducts: " + ex.Message);
                response.Message += ex.ToString();
                return response;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetProductsByBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetProductsBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll UpdateProductBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

    }
}
