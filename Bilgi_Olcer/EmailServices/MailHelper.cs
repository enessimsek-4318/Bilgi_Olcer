using System.Net.Mail;
using System.Net;

namespace Bilgi_Olcer.EmailServices
{
    public class MailHelper
    {
        //SMTP(Simple Mail Transfer Protocol)
        public static bool SendEmail(string body, string to, string subject, bool isHtml = true)
        {
            return SendEmail(body, new List<string> { to }, subject, isHtml);
        }

        public static bool SendEmail(string body, List<string> to, string subject, bool isHtml = true)
        {
            bool result = false;
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("enes.dcc@hotmail.com");

                to.ForEach(x =>
                {
                    message.To.Add(new MailAddress(x));
                });
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHtml;

                using (var smtp = new SmtpClient("smtp-mail.outlook.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("enes.dcc@hotmail.com", "4318enes");

                    smtp.Send(message);
                    result = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
