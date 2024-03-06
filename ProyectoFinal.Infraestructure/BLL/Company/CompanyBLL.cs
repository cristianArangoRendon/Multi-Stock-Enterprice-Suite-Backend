using ActiveDirectoryBack.Core.Interfaces.Services;
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
        public CompanyBLL(ICompanyRepository companyRepository, ILogService logService)
        {
            _companyRepository = companyRepository;
            _logService = logService;
        }
        
        public async Task<ResponseDTO> CreateCompany(string Description, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                if(idRol == 1)
                {
                    return await _companyRepository.CreateCompany(Description);
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

        public async Task<ResponseDTO> DeleteCompany(int IdCompany, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                if(idRol == 1)
                {
                    return await _companyRepository.DeleteCompany(IdCompany);
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

            try
            {
                if(idRol == 1)
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

        public async Task<ResponseDTO> GetCompanyById(int IdCompany, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                if(idRol == 1)
                {
                    return await _companyRepository.GetCompanyById(IdCompany);
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

            try
            {
                if(IdRol == 1)
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
