using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace Alwalid.Cms.Api.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string fromemail, string subject, string htmlMessage)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("maandammaj1@gmail.com", "aqib yvyi jjln niwm"),
                EnableSsl = true,
            };
            return smtpClient.SendMailAsync($"{fromemail}", "maandammaj1@gmail.com", subject, htmlMessage);
        }
    }
}
