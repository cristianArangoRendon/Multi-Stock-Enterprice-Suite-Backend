using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Headquarter;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HeadquartersController : ControllerBase
    {
        private readonly IHeadquarterBLL _headquarters;
        public HeadquartersController(IHeadquarterBLL headquarters)
        {
            _headquarters = headquarters;
        }

        [HttpGet("/Headquarters")]
        public async Task<ResponseDTO> GetHeadquarters()
        {
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            return await _headquarters.GetHeadquaters( IdCompany);
        }

        [HttpPost("/Headquarters")]
        public async Task<ResponseDTO> CreateHeadquarters(CreateHeadquartersDTO create)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            create.idCompany = IdCompany;
            create.idUser = idUser;
            return await _headquarters.CreateHeadquaters(create);
        }



        [HttpPut("/Headquarters")]
        public async Task<ResponseDTO> UpdateHeadquarters(UpdateHeadquarters update)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            update.idCompany = IdCompany;
            update.idUser = idUser;
            return await _headquarters.UpdateHeadquaters(update);
        }


    }
}
