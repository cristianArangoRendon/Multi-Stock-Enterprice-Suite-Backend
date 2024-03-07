using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Company;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Company;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Company
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IExecuteStoredProcedureServiceService _ExecuteStoredProcedureServiceService;

        public CompanyRepository(IExecuteStoredProcedureServiceService service) => _ExecuteStoredProcedureServiceService = service;
        
        public async Task<ResponseDTO> CreateCompany(string Description, string guidCompany)
        {
            
            var parameters = new
            {
                Description= Description,
                GuidCompany = guidCompany,
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("CreateCompany", parameters);
        }

        public async Task<ResponseDTO> DeleteCompany(string GuidCompany)
        {
            var parameters = new
            {
                GuidCompany = GuidCompany
            };

             return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("DeleteCompany", parameters);
        }

        public async Task<ResponseDTO> GetCompanies() => await _ExecuteStoredProcedureServiceService.ExecuteData("GetCompanies", MapToListHelper.MapToList<CompaniesDTO>);

        public async Task<ResponseDTO> GetCompanyById(string GuidCompany)
        {
            var parameters = new
            {
                GuidCompany = GuidCompany
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteSingleObjectStoredProcedure("GetCompanyById", parameters, MapToObjHelper.MapToObj<CompaniesDTO>);
        }

        public async Task<ResponseDTO> PostCompany(string description)
        {
            var parameters = new
            {
                Description = description
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("CreateCompany", parameters);
        }

        public async Task<ResponseDTO> PutCompany(int idCompany, string description)
        {
            var parameters = new
            {
                IdCompany = idCompany,
                Description = description
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("UpdateCompany", parameters);
        }
    }
}
