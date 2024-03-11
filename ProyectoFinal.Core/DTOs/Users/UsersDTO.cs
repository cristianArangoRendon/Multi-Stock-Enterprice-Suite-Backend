namespace ProyectoFinal.Core.DTOs.Users
{
    public class UsersDTO
    {
        public int idUser { get; set; }
        public string Names { get; set; }
        public string lastNames { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int idCompany { get; set; }
        public DateTime lastLoginDate { get; set; }
        public char gender { get; set; }
        public string image { get; set; }
        public int idRol { get; set; }
    }
}
