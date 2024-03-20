namespace ProyectoFinal.Core.DTOs.Bill
{
    public class BillDTO
    {
        public int idBill { get; set; }
        public int idMethodPayment { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nit { get; set; }
        public DateTime Date { get; set; }
        public decimal totalPrice { get; set; }
        public int  idUser { get; set; }
    }
}
