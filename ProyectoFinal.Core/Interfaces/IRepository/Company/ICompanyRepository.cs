using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Company
{
    public interface ICompanyRepository
    {
        public Task<ResponseDTO> GetCompanies();
        public Task<ResponseDTO> GetCompanyById(int IdCompany);
        public Task<ResponseDTO> CreateCompany(string Description);
        public Task<ResponseDTO> PutCompany(int idCompany, string description);
        public Task<ResponseDTO> PostCompany(string description);   
        public Task<ResponseDTO> DeleteCompany(int IdCompany);   
    }
}
