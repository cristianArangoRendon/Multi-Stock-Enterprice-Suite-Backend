using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BrandController : ControllerBase
    {


        private readonly IBrandBLL _BrandBLL;
     
        public BrandController(IBrandBLL brandBLL) => _BrandBLL = brandBLL;
        

        [HttpPost("/Create/Brand")]
        public async Task<ResponseDTO> CreateBrand(string Description) => await _BrandBLL.CreateBrandBLL(Description);
        

        [HttpGet("/Brands")]
        public async Task<ResponseDTO> GetBrand() => await _BrandBLL.GetBrandsBLL();
       

        [HttpGet("/Brand/By/Id")]
        public async Task<ResponseDTO> GetBrandById(int idBrand) => await _BrandBLL.GetBrandByIdBLL(idBrand);
        


        [HttpDelete("/Delete/Brand")]
        public async Task<ResponseDTO> DeleteBrand(int IdBrand) => await _BrandBLL.DeleteBrandBLL(IdBrand);
      


        [HttpPut("/Update/Brand")]
        public async Task<ResponseDTO> UpdateBrand(BrandDTO brandDTO) => await _BrandBLL.UpdateBrandBLL(brandDTO);
       

    }
}
