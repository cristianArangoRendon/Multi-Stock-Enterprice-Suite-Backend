using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.ProductsDoc
{
    public class GetProductsDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<ProductsDTO>
                {
                    new ProductsDTO
                    {
                        idProduct = 4,
                        Description = "Faro delantero LED",
                        stock = 8,
                        idCategory = 2,
                        idBrand = 4,
                        idProvider = 4,
                        UniqueCode = "POIUYTREWQ654321",
                        idUser = 4
                    },
                    new ProductsDTO
                    {
                        idProduct = 5,
                        Description = "Batería de arranque",
                        stock = 10,
                        idCategory = 2,
                        idBrand = 5,
                        idProvider = 5,
                        UniqueCode = "MNBVCXZQWE147258",
                        idUser = 5
                    },
                    new ProductsDTO
                    {
                        idProduct = 6,
                        Description = "Pastillas de freno",
                        stock = 15,
                        idCategory = 2,
                        idBrand = 6,
                        idProvider = 6,
                        UniqueCode = "LKJHGFDSA963852",
                        idUser = 6
                    },
                    new ProductsDTO
                    {
                        idProduct = 7,
                        Description = "Kit de transmisión",
                        stock = 6,
                        idCategory = 2,
                        idBrand = 7,
                        idProvider = 7,
                        UniqueCode = "UYTREWQASD852369",
                        idUser = 7
                    },
                    new ProductsDTO
                    {
                        idProduct = 8,
                        Description = "Amortiguadores traseros",
                        stock = 4,
                        idCategory = 2,
                        idBrand = 8,
                        idProvider = 8,
                        UniqueCode = "QAZXSWEDCV753159",
                        idUser = 8
                    },
                    new ProductsDTO
                    {
                        idProduct = 9,
                        Description = "Cadena de distribución",
                        stock = 7,
                        idCategory = 2,
                        idBrand = 9,
                        idProvider = 9,
                        UniqueCode = "RFVTGBYHNU147258",
                        idUser = 9
                    },
                    new ProductsDTO
                    {
                        idProduct = 10,
                        Description = "Filtro de aire",
                        stock = 12,
                        idCategory = 2,
                        idBrand = 10,
                        idProvider = 10,
                        UniqueCode = "QWERTYUIOP369258",
                        idUser = 10
                    },
                    new ProductsDTO
                    {
                        idProduct = 11,
                        Description = "Escape deportivo",
                        stock = 3,
                        idCategory = 2,
                        idBrand = 11,
                        idProvider = 11,
                        UniqueCode = "ASDFGHJKLPOI98765",
                        idUser = 11
                    },
                    new ProductsDTO
                    {
                        idProduct = 12,
                        Description = "Sistema de frenos ABS",
                        stock = 2,
                        idCategory = 2,
                        idBrand = 12,
                        idProvider = 12,
                        UniqueCode = "ZXCVBNMASD456789",
                        idUser = 12
                    },
                    new ProductsDTO
                    {
                        idProduct = 13,
                        Description = "Bujías de alto rendimiento",
                        stock = 9,
                        idCategory = 2,
                        idBrand = 13,
                        idProvider = 13,
                        UniqueCode = "UIOPLKJHGF147258",
                        idUser = 13
                    },
                    new ProductsDTO
                    {
                        idProduct = 14,
                        Description = "Kit de carenado completo",
                        stock = 5,
                        idCategory = 2,
                        idBrand = 14,
                        idProvider = 14,
                        UniqueCode = "YUIOPLKJHGF852369",
                        idUser = 14
                    },
                    new ProductsDTO
                    {
                        idProduct = 15,
                        Description = "Bomba de freno radial",
                        stock = 6,
                        idCategory = 2,
                        idBrand = 15,
                        idProvider = 15,
                        UniqueCode = "PLKJHGFDSAXCVBNM",
                        idUser = 15
                    },
                    new ProductsDTO
                    {
                        idProduct = 16,
                        Description = "Embrague antirrebote",
                        stock = 4,
                        idCategory = 2,
                        idBrand = 16,
                        idProvider = 16,
                        UniqueCode = "ASDFGHJKLQWERTYU",
                        idUser = 16
                    },
                    new ProductsDTO
                    {
                        idProduct = 17,
                        Description = "Kit de luces LED",
                        stock = 8,
                        idCategory = 2,
                        idBrand = 17,
                        idProvider = 17,
                        UniqueCode = "ZXCVBNMQWERTYUIO",
                        idUser = 17
                    },
                    new ProductsDTO
                    {
                        idProduct = 18,
                        Description = "Cilindro maestro de freno",
                        stock = 3,
                        idCategory = 2,
                        idBrand = 18,
                        idProvider = 18,

                    }
                }
            };
        }
    }
}
