using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SendMailWithGoogleSMTP
    {
        static void Main(string[] args)
        {
            string fromMail = "gaderushi7393@gmail.com";
            string fromPassword = "tbid nxpy axgx ophp";

            MailMessage message = new MailMessage();    
            message.From = new MailAddress(fromMail);
            message.Subject = "Test Subject";
            message.To.Add(new MailAddress("gaderushi7393@gmail.com"));
            message.Body = "<html><body> Test Body </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };
            smtpClient.Send(message);

        }
    }
}
