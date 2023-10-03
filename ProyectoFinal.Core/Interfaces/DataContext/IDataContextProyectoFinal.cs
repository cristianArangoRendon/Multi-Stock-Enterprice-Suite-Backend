using System.Data.SqlClient;

namespace ProyectoFinal.Core.Interfaces.DataContext
{
    public interface IDataContextProyectoFinal
    {
        SqlConnection GetConnection();
        SqlCommand CreateCommand();
    }
}
