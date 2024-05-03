using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IServices;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ProyectoFinal.Infraestructure.Services.ExecuteStoredProcedureServiceService
{
    public class ExecuteStoredProcedureServiceService : IExecuteStoredProcedureServiceService
    {


        private readonly IDataContextProyectoFinal _DataContext;
        private readonly ILogService _logService;
        private readonly ISqlCommandService _sqlCommandService;

        public ExecuteStoredProcedureServiceService(IDataContextProyectoFinal datacontext, ILogService logs, ISqlCommandService command)
        {
            _DataContext = datacontext;
            _logService = logs;
            _sqlCommandService = command;
        }

        public async Task<ResponseDTO> ExecuteData<TResult>(string storedProcedureName, Func<SqlDataReader, List<TResult>> mapFunction)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = storedProcedureName;
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                List<TResult> resultList = mapFunction(reader);
                if (resultList.Count == 0)
                {
                    response.Message = "This Id does not contain information.";
                    response.IsSuccess = true;
                    response.Data = null;
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = "Successfull Operation.";
                    response.Data = resultList;
                }
                return response;


            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages($"Se ha producido un error al ejecutar el SP {storedProcedureName}: {ex.Message}");
                response.Message += ex.ToString();
                return response;
            }

        }

        public async Task<ResponseDTO> ExecuteDataStoredProcedure<TResult>(string storedProcedureName, object parameters, Func<SqlDataReader, List<TResult>> mapFunction)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
         
                try
                {
                    using SqlCommand command = _DataContext.CreateCommand();
                    command.CommandText = storedProcedureName;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 1;
                    _sqlCommandService.AddParameters(command, parameters);
                    using SqlDataReader reader = await command.ExecuteReaderAsync();
                    List<TResult> resultList = mapFunction(reader);
                    if (resultList.Count == 0)
                    {
                        response.Message = "This Id does not contain information.";
                        response.IsSuccess = true;
                        response.Data = null;
                    }
                    else
                    {
                        response.IsSuccess = true;
                        response.Message = "Successfull Operation.";
                        response.Data = resultList;
                    }
                    return response;


                }
                catch (Exception ex)
                {
                    _logService.SaveLogsMessages($"Se ha producido un error al ejecutar el SP {storedProcedureName}: {ex.Message}");
                    response.Message += ex.ToString();
                    return response;
                }
        }



        public async Task<ResponseDTO> ExecuteSingleObjectStoredProcedure<TResult>(string storedProcedureName, object parameters, Func<SqlDataReader, TResult> mapFunction)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

                await Task.Run(async () =>
                {
                    try
                    {
                        using SqlCommand command = _DataContext.CreateCommand();
                        command.CommandText = storedProcedureName;
                        command.CommandType = CommandType.StoredProcedure;
                        _sqlCommandService.AddParameters(command, parameters);
                        using SqlDataReader reader = await command.ExecuteReaderAsync();
                        TResult resultList = mapFunction(reader);
                        if (resultList == null)
                        {
                            response.Message = "This Id does not contain information.";
                            response.IsSuccess = true;
                            response.Data = null;
                        }
                        else
                        {
                            response.IsSuccess = true;
                            response.Message = "Successfull Operation.";
                            response.Data = resultList;
                        }
                        return response;
                    }
                    catch (Exception ex)
                    {
                        _logService.SaveLogsMessages($"Se ha producido un error al ejecutar el SP {storedProcedureName}: {ex.Message}");
                        response.Message += ex.ToString();
                        return response;
                    }

                }
        
            );
           return response;
        }


        public async Task<ResponseDTO> ExecuteStoredProcedure(string storedProcedureName, object parameters)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = storedProcedureName;
                command.CommandType = CommandType.StoredProcedure;
                _sqlCommandService.AddParameters(command, parameters);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages($"Se ha producido un error al ejecutar el SP {storedProcedureName}: {ex.Message}");
                response.Message += ex.ToString();
                return response;
            }

        }
    }
}
