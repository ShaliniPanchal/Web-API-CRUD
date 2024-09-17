using System.Net;
using System.Net.Mail;

namespace ProductCRUDApp.Services
{
    public class EmailService
    {
        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.your-email-provider.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your-email@example.com", "your-password"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("your-email@example.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(recipient);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
