namespace ProyectoFinal.Core.DTOs.Bill
{
    public class UpdateBill
    {
        public int idBill { get; set; }
        public int idMethodPayment { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string nit { get; set; }
        public DateTime date { get; set; }
        public decimal totalPrice { get; set; }
        public int idUser { get; set; }
        public int idCompany { get; set; }
    }
}
