using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Company;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly ICompanyBLL _CompanyBLL;
        public CompanyController(ICompanyBLL companyBLL) => _CompanyBLL = companyBLL;


        /// <summary>
        /// Retrieves all companies.
        /// </summary>
        /// <remarks>This endpoint retrieves all companies available in the system.</remarks>
        [HttpGet("/Companies")]
        public async Task<ResponseDTO> GetCompanies()
        {
            var Rol = User.Claims.FirstOrDefault(x => x.Type == "IdRol");
            int IdRol = int.Parse(Rol.Value.ToString());

            return await _CompanyBLL.GetCompanies(IdRol);
        }
        /// <summary>
        /// Retrieves a company by its ID.
        /// </summary>
        /// <param name="idCompany">- `idCompany`: The ID of the company to retrieve.</param>
        /// <remarks>This endpoint retrieves a company based on the provided company ID.</remarks>
        [HttpGet("/Company/ById")]
        public async Task<ResponseDTO> GetCompany(int idCompany) 
        {
            var Rol = User.Claims.FirstOrDefault(x => x.Type == "IdRol");
            int IdRol = int.Parse(Rol.Value.ToString());
            return await _CompanyBLL.GetCompanyById(idCompany, IdRol);
        }

        /// <summary>
        /// Creates a new company.
        /// </summary>
        /// <param name="Description">- `Description`: The description of the company.</param>
        /// <remarks>This endpoint creates a new company with the provided description.</remarks>
        [HttpPost("/Create/company")]
        public async Task<ResponseDTO> CreateCompany(string Description) 
        {
            var Rol = User.Claims.FirstOrDefault(x => x.Type == "IdRol");
            int IdRol = int.Parse(Rol.Value.ToString());
            return await _CompanyBLL.CreateCompany(Description, IdRol);
        }
          

        /// <summary>
        /// Updates a company.
        /// </summary>
        /// <param name="idCompany">- `idCompany`: The ID of the company to update.</param>
        /// <param name="description">- `description`: The new description of the company.</param>
        /// <remarks>This endpoint updates a company's description based on the provided company ID.</remarks>
        [HttpPut("/Update/Company")]
        public async Task<ResponseDTO> PutCompany(int idCompany, string description)
        {
            var Rol = User.Claims.FirstOrDefault(x => x.Type == "IdRol");
            int IdRol = int.Parse(Rol.Value.ToString());
            return await _CompanyBLL.PutCompany(idCompany, description, IdRol);
        }
            
         

        /// <summary>
        /// Deletes a company by its ID.
        /// </summary>
        /// <param name="IdCompany">- `IdCompany`: The ID of the company to delete.</param>
        /// <remarks>This endpoint deletes a company based on the provided company ID.</remarks>
        [HttpDelete("/Delete/Company")]
        public async Task<ResponseDTO> DeleteCompany(int IdCompany)
        {
            var Rol = User.Claims.FirstOrDefault(x => x.Type == "IdRol");
            int IdRol = int.Parse(Rol.Value.ToString());
            return await _CompanyBLL.DeleteCompany(IdCompany, IdRol);
        }
            
            
           


    }
}
