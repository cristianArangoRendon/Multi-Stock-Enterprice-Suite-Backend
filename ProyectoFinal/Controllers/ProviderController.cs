using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProviderController : Controller
    {
        private readonly IProviderBLL _ProviderBLL;

        public ProviderController(IProviderBLL providerBLL) => _ProviderBLL = providerBLL;

        /// <summary>
        /// Retrieves all providers.
        /// </summary>
        /// <remarks>This endpoint retrieves all providers available in the system.</remarks>
        [HttpGet("/Provider")]
        public async Task<ResponseDTO> GetProvider() => await _ProviderBLL.GetProviderBLL();

        /// <summary>
        /// Retrieves a provider by its ID.
        /// </summary>
        /// <param name="IdProvider">- `IdProvider`: The ID of the provider to retrieve.</param>
        /// <remarks>This endpoint retrieves a provider based on the provided provider ID.</remarks>
        [HttpGet("/Provider/By/Id")]
        public async Task<ResponseDTO> GetProviderById(int IdProvider) => await _ProviderBLL.GetProviderByIdBLL(IdProvider);

        /// <summary>
        /// Deletes a provider by its ID.
        /// </summary>
        /// <param name="idProvider">- `idProvider`: The ID of the provider to delete.</param>
        /// <remarks>This endpoint deletes a provider based on the provided provider ID.</remarks>
        [HttpDelete("/Provider")]
        public async Task<ResponseDTO> DeleteProvider(int idProvider) => await _ProviderBLL.DeleteProviderBLL(idProvider);

        /// <summary>
        /// Updates a provider.
        /// </summary>
        /// <param name="provider">- `provider`: The data of the provider to be updated.</param>
        /// <remarks>This endpoint updates a provider with the provided provider data.</remarks>
        [HttpPut("/Provider")]
        public async Task<ResponseDTO> UpdateProvider(ProviderDTO provider) => await _ProviderBLL.UpdateProviderBLL(provider);

        /// <summary>
        /// Creates a new provider.
        /// </summary>
        ///  /// <param name="Description">
        /// - `Description`: The description of the Provider.
        /// </param>
        /// <remarks>This endpoint creates a new provider with the provided name.</remarks>
        [HttpPost("/Provider")]
        public async Task<ResponseDTO> CreateProvider(string Description)
        {

            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());

            return await _ProviderBLL.CreateProviderBLL(Description, IdCompany);
        }





    }
}
