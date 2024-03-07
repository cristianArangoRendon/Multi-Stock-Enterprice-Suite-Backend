using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Company
{
    public interface ICompanyRepository
    {
        public Task<ResponseDTO> GetCompanies();
        public Task<ResponseDTO> GetCompanyById(string GuidCompany);
        public Task<ResponseDTO> CreateCompany(string Description, string guidCompany);
        public Task<ResponseDTO> PutCompany(int idCompany, string description);
        public Task<ResponseDTO> PostCompany(string description);   
        public Task<ResponseDTO> DeleteCompany(string GuidCompany);   
    }
}
