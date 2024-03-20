using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Company;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyBLL _companyBLL;

        public CompanyController(ICompanyBLL companyBLL) => _companyBLL = companyBLL;

        /// <summary>
        /// Retrieves a list of companies based on the user's role.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a list of companies from the system based on the user's role.
        /// It requires the user's role identifier to determine the companies accessible to the user.
        /// </remarks>
        /// <returns>A response containing the list of companies.</returns>
        [HttpGet("/Companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var roleId = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int idRol = int.Parse(roleId.Value.ToString());

            var response = await _companyBLL.GetCompanies(idRol);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }


        /// <summary>
        /// Retrieves a company by its unique identifier.
        /// </summary>
        /// <param name="guidCompany">
        /// - `guidCompany`: The unique identifier (GUID) of the company to retrieve.
        /// </param>
        /// <remarks>
        /// This endpoint retrieves a company from the system based on its unique identifier.
        /// It requires the user's role identifier to determine the access rights.
        /// </remarks>
        /// <returns>A response containing the requested company.</returns>
        [HttpGet("/Company/ById")]
        public async Task<IActionResult> GetCompany(string guidCompany)
        {
            var roleId = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int idRol = int.Parse(roleId.Value.ToString());

            var response = await _companyBLL.GetCompanyById(guidCompany, idRol);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Creates a new company.
        /// </summary>
        /// <param name="description">
        /// - `description`: The description of the new company to create.
        /// </param>
        /// <remarks>
        /// This endpoint creates a new company in the system with the provided description.
        /// It requires the user's role identifier to determine the access rights.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>
        [HttpPost("/company")]
        public async Task<IActionResult> CreateCompany(string description)
        {
            var roleId = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int idRol = int.Parse(roleId.Value.ToString());

            var response = await _companyBLL.CreateCompany(description, idRol);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }


        /// <summary>
        /// Updates a company.
        /// </summary>
        /// <param name="idCompany">
        /// - `idCompany`: The unique identifier of the company to update.
        /// </param>
        /// <param name="description">
        /// - `description`: The new description for the company.
        /// </param>
        /// <remarks>
        /// This endpoint updates a company in the system based on its unique identifier and the provided description.
        /// It requires the user's role identifier to determine the access rights.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the update operation.</returns>
        [HttpPut("/Company")]
        public async Task<IActionResult> PutCompany(int idCompany, string description)
        {
            var roleId = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int idRol = int.Parse(roleId.Value.ToString());

            var response = await _companyBLL.PutCompany(idCompany, description, idRol);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }


        /// <summary>
        /// Deletes a company by its unique identifier.
        /// </summary>
        /// <param name="guidCompany">
        /// - `guidCompany`: The unique identifier (GUID) of the company to delete.
        /// </param>
        /// <remarks>
        /// This endpoint deletes a company from the system based on its unique identifier.
        /// It requires the user's role identifier to determine the access rights.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the deletion operation.</returns>
        [HttpDelete("/Company")]
        public async Task<IActionResult> DeleteCompany(string guidCompany)
        {
            var roleId = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int idRol = int.Parse(roleId.Value.ToString());

            var response = await _companyBLL.DeleteCompany(guidCompany, idRol);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

    }
}
