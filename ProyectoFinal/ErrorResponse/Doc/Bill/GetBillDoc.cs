using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Bill
{
    public class GetBillDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<BillDTO>
                {
                    new BillDTO
                    {
                       idBill = 1,
                       idMethodPayment = 1,
                       Name = "John",
                       LastName = "Doe",
                       Nit = "123456789",
                       Date = DateTime.Now,
                       totalPrice = 100.00m,
                       idUser = 123
                    },

                    new BillDTO
                    {
                        idBill = 2,
                        idMethodPayment = 2,
                        Name = "Alice",
                        LastName = "Smith",
                        Nit = "987654321",
                        Date = DateTime.Now.AddDays(-1),
                        totalPrice = 150.00m,
                        idUser = 456
                    },

                    new BillDTO
                    {
                        idBill = 3,
                        idMethodPayment = 3,
                        Name = "Bob",
                        LastName = "Johnson",
                        Nit = "456123789",
                        Date = DateTime.Now.AddDays(-2),
                        totalPrice = 200.00m,
                        idUser = 789
                    }
                }
            };
        }
    }
}
