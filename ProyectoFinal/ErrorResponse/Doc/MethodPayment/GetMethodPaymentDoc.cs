using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.MethodPayment;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.MethodPayment
{
    public class GetMethodPaymentDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<MethodPaymentDTO>
                {
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 1,
                            Description = "Efectivo"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 2,
                            Description = "Tarjeta de débito"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 3,
                            Description = "Tarjeta de crédito"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 4,
                            Description = "Transferencia bancaria"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 5,
                            Description = "Pago móvil"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 6,
                            Description = "Cheque"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 7,
                            Description = "Vale de compra"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 8,
                            Description = "Bitcoin"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 9,
                            Description = "PayPal"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 10,
                            Description = "Apple Pay"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 11,
                            Description = "Google Pay"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 12,
                            Description = "Samsung Pay"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 13,
                            Description = "Western Union"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 14,
                            Description = "MoneyGram"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 15,
                            Description = "Transferencia electrónica"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 16,
                            Description = "Bizum"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 17,
                            Description = "Domiciliación bancaria"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 18,
                            Description = "Criptomonedas"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 19,
                            Description = "Pago en tienda física"
                        },
                        new MethodPaymentDTO
                        {
                            idMethodPayment = 20,
                            Description = "Pago por teléfono"
                        }

                }
            };
        }
    }
}
