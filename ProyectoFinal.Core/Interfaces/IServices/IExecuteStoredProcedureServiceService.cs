using ProyectoFinal.Core.DTOs.Response;
using System.Data.SqlClient;

namespace ProyectoFinal.Core.Interfaces.IServices
{
    public interface IExecuteStoredProcedureServiceService
    {
        Task<ResponseDTO> ExecuteStoredProcedure(string storedProcedureName, object parameters);
        Task<ResponseDTO> ExecuteDataStoredProcedure<TResult>(string storedProcedureName, object parameters, Func<SqlDataReader, List<TResult>> mapFunction);
        Task<ResponseDTO> ExecuteData<TResult>(string storedProcedureName, Func<SqlDataReader, List<TResult>> mapFunction);
        Task<ResponseDTO> ExecuteSingleObjectStoredProcedure<TResult>(string storedProcedureName, object parameters, Func<SqlDataReader, TResult> mapFunction);
    }
}

