﻿namespace ProyectoFinal.Core.DTOs.Users
{
    public class CreateUserDTO
    {
        public string Names { get; set; }
        public string lastNames { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int idRol { get; set; }
        public int idCompany { get; set; }
    }
}