using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.MethodPayment;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MethodPaymentController : ControllerBase
    {
        private readonly IMethodPaymentBLL _methodPayment;
        public MethodPaymentController(IMethodPaymentBLL methodPayment)
        {
            _methodPayment = methodPayment;
        }

        [HttpPost("/MethodPayment")]
        public async Task<ResponseDTO>CreateMethodPayment(string description) => await _methodPayment.CreateMethodPayment(description);

        [HttpGet("/MethodPayment")]
        public async Task<ResponseDTO> GetMethodPayment() => await _methodPayment.GetMethodPayment();

        [HttpDelete("/MethodPayment")]
        public async Task<ResponseDTO> DeleteMethodPayment(int idMethodPayment) => await _methodPayment.DeleteMethodPayment(idMethodPayment);

        [HttpPut("/MethodPayment")]
        public async Task<ResponseDTO> UpdateMethodPayment(int idMethodPayment, string Description) => await _methodPayment.UpdateMethodPayment(idMethodPayment, Description);
    }
}
