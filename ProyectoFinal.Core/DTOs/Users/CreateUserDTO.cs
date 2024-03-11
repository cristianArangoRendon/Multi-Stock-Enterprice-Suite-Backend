namespace ProyectoFinal.Core.DTOs.Users
{
    public class CreateUserDTO
    {
        public string Names { get; set; }
        public string lastNames { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int IdCompany { get; set; }
        public int IdRol { get; set; }
        public char Gender { get; set; }
        public string Image { get; set; }
    }
}
