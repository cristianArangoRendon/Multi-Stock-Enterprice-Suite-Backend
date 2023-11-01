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

        [HttpGet("/Get/Provider")]
        public async Task<ResponseDTO> GetProvider( ) => await _ProviderBLL.GetProviderBLL();
        

        [HttpGet("/Get/Provider/By/Id")]
        public async Task<ResponseDTO> GetProviderById(int IdProvider) => await _ProviderBLL.GetProviderByIdBLL(IdProvider);
        

        [HttpDelete("/Delete/Provider")]
        public async Task<ResponseDTO> DeleteProvider(int idProvider) => await _ProviderBLL.DeleteProviderBLL(idProvider);
        

        [HttpPut("/Update/Provider")]
        public async Task<ResponseDTO> UpdateProvider(ProviderDTO provider)  => await _ProviderBLL.UpdateProviderBLL(provider);
        

        [HttpPost("/Create/Provider")]
        public async Task<ResponseDTO> CreateProvider(string provider)  => await _ProviderBLL.CreateProviderBLL(provider);
        



    }
}
