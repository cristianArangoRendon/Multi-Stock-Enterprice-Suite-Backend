using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Warehouse;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseBLL _warehouse;
        public WarehouseController(IWarehouseBLL warehouse)
        {
            _warehouse = warehouse;
        }



        [HttpGet("/Warehouse")]
        public async Task<ResponseDTO> GetWarehouse(int idHeadquarter)
        {
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            return await _warehouse.GetWarehouse(idHeadquarter, IdCompany);
        }
            
            
           


        [HttpPost("/Warehouse")]
        public async Task<ResponseDTO> PostWarehouse(int idHeadquarter, string Description)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            return await _warehouse.CreateWarehouse(idHeadquarter, Description, idUser, IdCompany);
        }
           
    }
}
