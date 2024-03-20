using Microsoft.Extensions.Configuration;
using ProyectoFinal.Core.Interfaces.IServices;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace ProyectoFinal.Infraestructure.Services.SendEmailService
{
    public class SendEmailService : ISendEmailService
    {
        private readonly IConfiguration _configuration;
    
        public SendEmailService(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public bool SendEmail(string Email, string menssage, string subject)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_configuration["Email"]);
            mail.To.Add(Email);
            mail.Subject = subject;
            mail.Body = menssage;
            ContentType mimeType = new System.Net.Mime.ContentType("text/html");
            AlternateView alternate = AlternateView.CreateAlternateViewFromString(menssage, mimeType);
            mail.AlternateViews.Add(alternate);
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(_configuration["Email"], _configuration["secretKey"]);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;
        }
    }
}
