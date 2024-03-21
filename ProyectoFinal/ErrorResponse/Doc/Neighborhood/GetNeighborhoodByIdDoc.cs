using ProyectoFinal.Core.DTOs.Neighborhood;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Neighborhood
{
    public class GetNeighborhoodByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new NeighborhoodDTO
                {
                    idNeighborhood = 1,
                    Description = "Bello",  
                }
            };
        }
    }
}
