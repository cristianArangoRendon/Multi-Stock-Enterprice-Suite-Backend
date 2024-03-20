namespace ProyectoFinal.Core.DTOs.Headquarters
{
    public class UpdateHeadquarters
    {
        public int idHeadquarter { get; set; }
        public string Description { get; set; }
        public int idCompany { get; set; }
        public int idCity { get; set; }
        public int idUser { get; set; }
    }
}
