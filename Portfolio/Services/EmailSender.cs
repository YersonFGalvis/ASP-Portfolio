using Portfolio.Models;
using Portfolio.Services.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Services
{
    public class EmailSender: IEmailSender
    {
        public readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Send(ContactoDTO contact)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_TO");
            
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contact.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var message = contact.Mensaje;
            var Htmlcontent = @$"DE:{ contact.Nombre } -
            EMAIL: {contact.Email}
            MENSAJE: {contact.Mensaje}";

            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, message, Htmlcontent);
            var respuesta = await client.SendEmailAsync(singleEmail);
        }
    }
}
