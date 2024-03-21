using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Bill
{
    public class GetBillByIdDOC : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new BillDTO
                {
                    idBill = 1,
                    idMethodPayment = 1,
                    Name = "Elena",
                    LastName = "Garcia",
                    Nit = "789456123",
                    Date = DateTime.Now,
                    totalPrice = 120.50m,
                    idUser = 111
                }
            };
        }

    }
}
