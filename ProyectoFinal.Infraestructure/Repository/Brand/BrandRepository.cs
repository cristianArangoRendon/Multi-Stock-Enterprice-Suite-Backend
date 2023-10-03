using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Brand;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Brand
{
    public
        class BrandRepository : IBrandRepository
    {
        private readonly IDataContextProyectoFinal _context;
        private readonly ILogService _logService;

        public BrandRepository(IDataContextProyectoFinal context, ILogService logService)
        {
            _context = context;
            _logService = logService;
        }

        public async Task<ResponseDTO> CreateBrandRepository( string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.CreateBrand";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description", Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;

            }
            catch(Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateBrand: " + ex.Message);
                response.Message += ex.ToString();
                return response;

            }
        }

        public async Task<ResponseDTO> DeleteBrandRepository(int IdBrand)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.DeleteBrand";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idBrand", IdBrand);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.IsSuccess = true;
                await reader.ReadAsync();
                response.Message = "Successful Petition";
                return response;

            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateBrand: " + ex.Message);
                response.Message += ex.ToString();
                return response;

            }
        }

        public async Task<ResponseDTO> GetBrandByIdRepository( int IdBrand)
        { 
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.GetBrandById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdBrand", IdBrand);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToObjHelper.MapToObj<BrandDTO>(reader);
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetBrandById: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetBrandsRepository()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.GetBrands";
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToListHelper.MapToList<BrandDTO>(reader);
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetBrands: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateBrandRepository(BrandDTO brandDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.UpdateBrand";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdBrand", brandDTO.IdBrand);
                command.Parameters.AddWithValue("@Description", brandDTO.Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
        
                await reader.ReadAsync();
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  UpdateBrand: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
