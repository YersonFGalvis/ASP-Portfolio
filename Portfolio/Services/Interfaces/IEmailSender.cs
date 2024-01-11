using Portfolio.Models;

namespace Portfolio.Services.Interfaces
{
    public interface IEmailSender
    {
        Task Send(ContactoDTO contact);
    }
}
