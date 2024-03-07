namespace ProyectoFinal.Core.DTOs.Products
{
    public class CreateProductDTO
    {
        public string Description { get; set; }
        public int minimunQuantity { get; set; }
        public int stock { get; set; }
        public int idCategory { get; set; }
        public int idBrand { get; set; }
        public int idProvider { get; set; }
        public int uniqueCode { get; set; }
        public int idCompany { get; set; }

    }
}
