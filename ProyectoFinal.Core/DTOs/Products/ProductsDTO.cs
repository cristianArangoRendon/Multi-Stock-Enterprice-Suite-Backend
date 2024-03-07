namespace ProyectoFinal.Core.DTOs.Products
{
    public class ProductsDTO
    {
        public int idProduct { get; set; }
        public string Description { get; set; }
        public int minimunQuantity { get; set; }
        public int stock { get; set; }
        public int idCategory { get; set; }
        public int idBrand { get; set; }
        public int idProvider { get; set; }
        public int UniqueCode { get; set; }
    }
}
