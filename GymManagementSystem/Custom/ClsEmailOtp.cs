using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Custom
{
    internal class ClsEmailOtp
    {
        public void EmailSender(string To,string From,string Subject,string Body)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(To);
                message.From = new MailAddress(From);
                message.Subject = Subject;
                message.Body = Body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential(From, "wzaxgigzngugjzbp");
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
            catch
            {

            }
        }
    }
}
