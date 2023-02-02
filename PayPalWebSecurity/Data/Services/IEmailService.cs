using PayPalWebSecurity.Models;
using SendGrid;
using System.Threading.Tasks;

namespace PayPalWebSecurity.Data.Services
{
    public interface IEmailService
    {
        Task<Response> SendSingleEmail(ComposeEmailModel payload);
    }
}
