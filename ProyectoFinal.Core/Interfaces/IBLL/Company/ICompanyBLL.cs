using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Company
{
    public interface ICompanyBLL
    {
        public Task<ResponseDTO> GetCompanies(int idRol);
        public Task<ResponseDTO> GetCompanyById(string GuidCompany, int idRol);
        public Task<ResponseDTO> CreateCompany(string Description, int idRol);
        public Task<ResponseDTO> PutCompany(int idCompany, string description, int idRol);
        public Task<ResponseDTO> DeleteCompany(string guidCompany, int idRol);
    }
}
