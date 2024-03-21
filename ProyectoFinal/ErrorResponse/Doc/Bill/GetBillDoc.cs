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
                        Name = "Elena",
                        LastName = "Garcia",
                        Nit = "789456123",
                        Date = DateTime.Now,
                        totalPrice = 120.50m,
                        idUser = 111
                    },

                    new BillDTO
                    {
                        idBill = 2,
                        idMethodPayment = 2,
                        Name = "Juan",
                        LastName = "Lopez",
                        Nit = "159357852",
                        Date = DateTime.Now.AddDays(-3),
                        totalPrice = 75.20m,
                        idUser = 222
                    },

                    new BillDTO
                    {
                        idBill = 3,
                        idMethodPayment = 3,
                        Name = "Maria",
                        LastName = "Martinez",
                        Nit = "456789123",
                        Date = DateTime.Now.AddDays(-5),
                        totalPrice = 180.75m,
                        idUser = 333
                    },

                    new BillDTO
                    {
                        idBill = 4,
                        idMethodPayment = 1,
                        Name = "Carlos",
                        LastName = "Rodriguez",
                        Nit = "753159852",
                        Date = DateTime.Now.AddDays(-2),
                        totalPrice = 90.00m,
                        idUser = 444
                    },

                    new BillDTO
                    {
                        idBill = 5,
                        idMethodPayment = 2,
                        Name = "Laura",
                        LastName = "Sanchez",
                        Nit = "852963741",
                        Date = DateTime.Now.AddDays(-1),
                        totalPrice = 200.30m,
                        idUser = 555
                    },

                    new BillDTO
                    {
                        idBill = 6,
                        idMethodPayment = 3,
                        Name = "Pedro",
                        LastName = "Gomez",
                        Nit = "369852147",
                        Date = DateTime.Now.AddDays(-4),
                        totalPrice = 150.60m,
                        idUser = 666
                    },

                    new BillDTO
                    {
                        idBill = 7,
                        idMethodPayment = 1,
                        Name = "Ana",
                        LastName = "Perez",
                        Nit = "147258369",
                        Date = DateTime.Now.AddDays(-6),
                        totalPrice = 100.20m,
                        idUser = 777
                    },

                    new BillDTO
                    {
                        idBill = 8,
                        idMethodPayment = 2,
                        Name = "Jose",
                        LastName = "Hernandez",
                        Nit = "321654987",
                        Date = DateTime.Now.AddDays(-7),
                        totalPrice = 85.50m,
                        idUser = 888
                    },

                    new BillDTO
                    {
                        idBill = 9,
                        idMethodPayment = 3,
                        Name = "Sofia",
                        LastName = "Diaz",
                        Nit = "258369147",
                        Date = DateTime.Now.AddDays(-8),
                        totalPrice = 120.00m,
                        idUser = 999
                    },

                    new BillDTO
                    {
                        idBill = 10,
                        idMethodPayment = 1,
                        Name = "Diego",
                        LastName = "Alvarez",
                        Nit = "654987321",
                        Date = DateTime.Now.AddDays(-9),
                        totalPrice = 95.80m,
                        idUser = 1010
                    },

                    new BillDTO
                    {
                        idBill = 11,
                        idMethodPayment = 2,
                        Name = "Lucia",
                        LastName = "Torres",
                        Nit = "987654321",
                        Date = DateTime.Now.AddDays(-10),
                        totalPrice = 180.25m,
                        idUser = 1111
                    },

                    new BillDTO
                    {
                        idBill = 12,
                        idMethodPayment = 3,
                        Name = "Gabriel",
                        LastName = "Ramirez",
                        Nit = "456123789",
                        Date = DateTime.Now.AddDays(-11),
                        totalPrice = 210.75m,
                        idUser = 1212
                    },

                    new BillDTO
                    {
                        idBill = 13,
                        idMethodPayment = 1,
                        Name = "Valentina",
                        LastName = "Fernandez",
                        Nit = "123456789",
                        Date = DateTime.Now.AddDays(-12),
                        totalPrice = 130.50m,
                        idUser = 1313
                    },

                    new BillDTO
                    {
                        idBill = 14,
                        idMethodPayment = 2,
                        Name = "Alejandro",
                        LastName = "Gutierrez",
                        Nit = "789456123",
                        Date = DateTime.Now.AddDays(-13),
                        totalPrice = 70.20m,
                        idUser = 1414
                    },

                    new BillDTO
                    {
                        idBill = 15,
                        idMethodPayment = 3,
                        Name = "Luisa",
                        LastName = "Morales",
                        Nit = "159357852",
                        Date = DateTime.Now.AddDays(-14),
                        totalPrice = 190.75m,
                        idUser = 1515
                    },

                    new BillDTO
                    {
                        idBill = 16,
                        idMethodPayment = 1,
                        Name = "Raul",
                        LastName = "Castillo",
                        Nit = "456789123",
                        Date = DateTime.Now.AddDays(-15),
                        totalPrice = 110.00m,
                        idUser = 1616
                    },

                    new BillDTO
                    {
                        idBill = 17,
                        idMethodPayment = 2,
                        Name = "Diana",
                        LastName = "Ortega",
                        Nit = "753159852",
                        Date = DateTime.Now.AddDays(-16),
                        totalPrice = 210.30m,
                        idUser = 1717
                    },

                    new BillDTO
                    {
                        idBill = 18,
                        idMethodPayment = 3,
                        Name = "Hector",
                        LastName = "Cruz",
                        Nit = "852963741",
                        Date = DateTime.Now.AddDays(-17),
                        totalPrice = 160.60m,
                        idUser = 1818
                    },

                    new BillDTO
                    {
                        idBill = 19,
                        idMethodPayment = 1,
                        Name = "Marta",
                        LastName = "Vargas",
                        Nit = "369852147",
                        Date = DateTime.Now.AddDays(-18),
                        totalPrice = 95.20m,
                        idUser = 1919
                    },

                    new BillDTO
                    {
                        idBill = 20,
                        idMethodPayment = 2,
                        Name = "Pablo",
                        LastName = "Sosa",
                        Nit = "147258369",
                        Date = DateTime.Now.AddDays(-19),
                        totalPrice = 80.50m,
                        idUser = 2020
                    }

                }
            };
        }
    }
}
