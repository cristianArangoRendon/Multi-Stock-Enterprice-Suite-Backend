namespace ProyectoFinal.Core.Interfaces.IServices
{
    public interface ISendEmailService
    {
        bool SendEmail(string Email, string menssage, string subject);
    }
}
