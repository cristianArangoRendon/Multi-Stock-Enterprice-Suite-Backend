using ProyectoFinal.Core.Interfaces.IServices;
using System.Data.SqlClient;
using System.Reflection;

namespace ProyectoFinal.Infraestructure.Services.SqlCommandService
{
    public class SqlCommandService : ISqlCommandService
    {
        public void AddParameters<T>(SqlCommand command, T parameters)
        {
            if (parameters != null)
            {
                PropertyInfo[] properties = parameters.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    string parameterName = $"@{property.Name}";
                    object value = property.GetValue(parameters);

                    command.Parameters.AddWithValue(parameterName, value ?? DBNull.Value);
                }
            }
        }
    }
}
