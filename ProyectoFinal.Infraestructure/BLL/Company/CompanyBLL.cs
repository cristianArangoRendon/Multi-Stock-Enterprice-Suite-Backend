using ActiveDirectoryBack.Core.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Company;
using ProyectoFinal.Core.Interfaces.IRepository.Company;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Company
{
    public class CompanyBLL : ICompanyBLL
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ILogService _logService;
        private readonly IConfiguration _configuration;
        public CompanyBLL(ICompanyRepository companyRepository, ILogService logService, IConfiguration configuration)
        {
            _companyRepository = companyRepository;
            _logService = logService;
            _configuration = configuration;
        }
        
        public async Task<ResponseDTO> CreateCompany(string Description, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int adminNumber = int.Parse(_configuration["SuperAdmin"]);
            try
            {
                if(idRol == adminNumber)
                {
                    Guid guid = Guid.NewGuid();
                    return await _companyRepository.CreateCompany(Description, guid.ToString());
                }
                else
                {
                    response.Message = "You do not have permission to Create companies.";
                }
                return response;

            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteCompany(string guidCompany, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            int adminNumber = int.Parse(_configuration["SuperAdmin"]);
            try
            {
                if(idRol == adminNumber)
                {
                    return await _companyRepository.DeleteCompany(guidCompany);
                }
                else
                {
                    response.Message = "You do not have permission to Delete companies.";
                }
                return response;

            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetCompanies(int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int adminNumber = int.Parse(_configuration["SuperAdmin"]);
            try
            {
                if(idRol == adminNumber)
                {
                    return await _companyRepository.GetCompanies();
                }
                else
                {
                    response.Message = "You do not have permission to obtain companies.";
                }
                return response; 
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetCompanyById(string  GuidCompany, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int adminNumber = int.Parse(_configuration["SuperAdmin"]);
            try
            {
                if(idRol == adminNumber)
                {
                    return await _companyRepository.GetCompanyById(GuidCompany);
                }
                else
                {
                    response.Message = "You do not have permission to obtain companies.";
                }
                return response;

            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }



        public async Task<ResponseDTO> PutCompany(int idCompany, string description, int IdRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int adminNumber = int.Parse(_configuration["SuperAdmin"]);
            try
            {
                if(IdRol == adminNumber)
                {
                    return await _companyRepository.PutCompany(idCompany, description);
                }
                else
                {
                    response.Message = "You do not have permission to Update companies.";
                }
                return response;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
