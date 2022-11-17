
using System.Net;
using System.Net.Mail;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.Infra.Services
{
    public class EmailService: IEmailService
    {
        
        public void SendEmail(string from, string recepient, string subject, string body)
        {
           

            MailMessage email = new MailMessage();

            email.From = new MailAddress(from);

            email.To.Add(new MailAddress(recepient));          

            email.Subject = subject;

            email.Body = body;

            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient("smtp.sendgrid.net",587);
            smtp.EnableSsl = false;

            smtp.Credentials = new NetworkCredential("apikey", "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");




            try
            {
                smtp.Send(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",  ex.ToString());
            }

            
        }
    }
}