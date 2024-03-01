using System.Data.SqlClient;

namespace ProyectoFinal.Core.Interfaces.IServices
{
    public interface ISqlCommandService
    {
        void AddParameters<T>(SqlCommand command, T parameters);
    }
}
