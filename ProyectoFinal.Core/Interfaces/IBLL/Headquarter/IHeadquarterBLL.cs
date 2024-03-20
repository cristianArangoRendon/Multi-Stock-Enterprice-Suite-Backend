using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Headquarter
{
    public interface IHeadquarterBLL
    {
        public Task<ResponseDTO> CreateHeadquaters(CreateHeadquartersDTO create);
        public Task<ResponseDTO> GetHeadquaters(int idCompany);
        public Task<ResponseDTO> UpdateHeadquaters(UpdateHeadquarters updateHeadquarters);
    }
}
