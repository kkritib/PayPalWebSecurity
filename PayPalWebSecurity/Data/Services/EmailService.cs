using Microsoft.Extensions.Configuration;
using PayPalWebSecurity.Data.Services;
using PayPalWebSecurity.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace PayPalWebSecurity.Data.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<Response> SendSingleEmail(ComposeEmailModel payload)
        {
            var apiKey = _configuration.GetSection("SendGrid")["ApiKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("kritib2502@gmail.com", "Kriti");
            var subject = payload.Subject;
            var to = new EmailAddress(payload.Email
                                     , $"{payload.FirstName} {payload.LastName}");
            var textContent = payload.Body;
            var htmlContent = $"<strong>{payload.Body}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject
                                                  , textContent, htmlContent);
            var request = client.SendEmailAsync(msg);
            request.Wait();
            var result = request.Result;
            return request;
        }
    }
}
