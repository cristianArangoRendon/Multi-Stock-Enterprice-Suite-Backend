using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Bill;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BillController : ControllerBase
    {
        private readonly IBillBLL _bill;
        public BillController(IBillBLL bill)
        {
            _bill = bill;
        }


        [HttpPost("/Bill")]
        public async Task<ResponseDTO> CreateBill(CreateBillDTO bill)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            bill.idUser = idUser;
            return await _bill.CreateBill(bill);
        }

        [HttpGet("/Bill")]
        public async Task<ResponseDTO> GetBill()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            return await _bill.GetBill(idUser);
        }


        [HttpGet("/Bill/By/Id")]
        public async Task<ResponseDTO> GetBillById(int idBill)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            return await _bill.GetBillById(idBill, idUser);
        }


        [HttpDelete("/Bill")]
        public async Task<ResponseDTO> DeleteBill(int idbill)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            return await _bill.DeleteBill(idbill,idUser);
        }
    }
}
