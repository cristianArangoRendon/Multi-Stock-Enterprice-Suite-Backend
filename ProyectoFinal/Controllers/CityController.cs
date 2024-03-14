using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.City;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : ControllerBase
    {
        private readonly ICitiesBLL _CitiesBLL;
        public CityController(ICitiesBLL citiesBLL)
        {
            _CitiesBLL = citiesBLL;
        }

        [HttpGet("/Cities")]
        public async Task<ResponseDTO> GetCities() => await _CitiesBLL.GetCities();


        [HttpGet("/City/ById")]
        public async Task<ResponseDTO> GetCityById(int idCity) => await _CitiesBLL.CityById(idCity);


        [HttpDelete("/City")]
        public async Task<ResponseDTO> DeleteCity(int idCity) => await _CitiesBLL.DeleteCiy(idCity);


        [HttpPut("/City")]
        public async Task<ResponseDTO> UpdateCity(int idCity, string Description) => await _CitiesBLL.UpdateCity(idCity, Description);

        [HttpPost("/City")]
        public async Task<ResponseDTO> CreateCity(string Description) => await _CitiesBLL.CreateCity(Description);
    }
}
