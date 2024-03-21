using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.ProductsDoc
{
    public class GetProductByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new ProductsDTO
                {
                    idProduct = 4,
                    Description = "Faro delantero LED",
                    stock = 8,
                    idCategory = 2,
                    idBrand = 4,
                    idProvider = 4,
                    UniqueCode = "POIUYTREWQ654321",
                    idUser = 4
                }
            };
        }
    }
}
